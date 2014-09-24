using Salesforce.Common;
using Salesforce.Force;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Web.Services.Salesforce
{
    public class SalesforceService
    {
        public SalesforceService()
        {
            this.AuthenticationClient = new AuthenticationClient();
        }

        public AuthenticationClient AuthenticationClient { get; private set; }

        public ForceClient GetForceClient()
        {
            if (!SalesforceService.IsUserLoggedIn())
            {
                throw new InvalidOperationException("The user must be logged in to get a ForceClient.");
            }

            // Retrieve the access token and instance URL from the session object, which were set in the SalesforceOAuthRedirectHandler.
            this.AuthenticationClient.AccessToken = HttpContext.Current.Session["AccessToken"] as string;
            this.AuthenticationClient.InstanceUrl = HttpContext.Current.Session["InstanceUrl"] as string;

            return new ForceClient(
                this.AuthenticationClient.InstanceUrl,
                this.AuthenticationClient.AccessToken,
                this.AuthenticationClient.ApiVersion);
        }

        public static bool IsUserLoggedIn()
        {
            return HttpContext.Current.Session["AccessToken"] != null;
        }

        internal static string GetAppSetting(string name)
        {
            string setting = ConfigurationManager.AppSettings[name];
            if (setting == null)
            {
                throw new InvalidOperationException(
                    String.Format(CultureInfo.InvariantCulture, "The key '{0}' is missing from the appSettings section of the config file.", name));
            }

            return setting;
        }
    }
}