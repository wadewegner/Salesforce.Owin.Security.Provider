using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using Owin;
using Salesforce.Owin.Security.Provider;

namespace Web
{
    public partial class Startup
    {
        public void ConfigureSalesforce(IAppBuilder app)
        {
            app.UseSalesforceAuthentication(new SalesforceAuthenticationOptions()
            {
                Endpoints =
                    new SalesforceAuthenticationOptions.
                        SalesforceAuthenticationEndpoints
                    {
                        AuthorizationEndpoint =
                            "https://login.salesforce.com/services/oauth2/authorize",
                        TokenEndpoint = "https://login.salesforce.com/services/oauth2/token",
                    },
                ClientId = "YOUR_CLIENT_ID",
                ClientSecret = "YOUR_CLIENT_SECRET",
                Provider = new SalesforceAuthenticationProvider()
                {
                    // TODO: 1. Add this to temporarily store the access token
                    OnAuthenticated = async context =>
                    {
                        context.Identity.AddClaim(new Claim("urn:tokens:salesforce:accesstoken", context.AccessToken));
                        context.Identity.AddClaim(new Claim("urn:tokens:salesforce:refreshtoken", context.RefreshToken));
                    }
                }
            });
        }
    }
}
