using Salesforce.Common;
using Salesforce.Common.Models;
using System;
using System.Threading.Tasks;
using System.Web;
using System.Web.SessionState;

namespace Web.Services.Salesforce
{
    public class SalesforceOAuthRedirectHandler : HttpTaskAsyncHandler, IRequiresSessionState
    {
        public override bool IsReusable
        {
            get { return true; }
        }

        public override async Task ProcessRequestAsync(HttpContext context)
        {
            AuthenticationClient authenticationClient = new AuthenticationClient();

            // Get the access and refresh tokens from the Salesforce authorization server, and store them
            // on the session object.
            await authenticationClient.WebServerAsync(
                SalesforceService.GetAppSetting("Salesforce:ConsumerKey"),
                SalesforceService.GetAppSetting("Salesforce:ConsumerSecret"),
                SalesforceOAuthRedirectHandler.GetAbsoluteRedirectUri(),
                context.Request.QueryString["code"],
                "common-libraries-dotnet",
                SalesforceService.GetAppSetting("Salesforce:Domain") + "/services/oauth2/token");

            context.Session["AccessToken"] = authenticationClient.AccessToken;
            context.Session["RefreshToken"] = authenticationClient.RefreshToken;
            context.Session["InstanceUrl"] = authenticationClient.InstanceUrl;

            context.Response.Redirect("~/", false);
        }

        public static Uri AuthorizationUri
        {
            get
            {
                string redirectToAuthorizeUrlString = Common.FormatAuthUrl(
                     SalesforceService.GetAppSetting("Salesforce:Domain") + "/services/oauth2/authorize",
                     ResponseTypes.Code,
                     SalesforceService.GetAppSetting("Salesforce:ConsumerKey"),
                     HttpUtility.UrlEncode(SalesforceOAuthRedirectHandler.GetAbsoluteRedirectUri()));

                return new Uri(redirectToAuthorizeUrlString);
            }
        }

        private static string GetAbsoluteRedirectUri()
        {
            Uri redirectUri;
            Uri.TryCreate(SalesforceService.GetAppSetting("Salesforce:RedirectUri"), UriKind.RelativeOrAbsolute, out redirectUri);
            if (redirectUri.IsAbsoluteUri)
            {
                return redirectUri.ToString();
            }
            else
            {
                string uriAuthority = HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority);
                return new Uri(new Uri(uriAuthority), redirectUri).ToString();
            }
        }
    }
}
