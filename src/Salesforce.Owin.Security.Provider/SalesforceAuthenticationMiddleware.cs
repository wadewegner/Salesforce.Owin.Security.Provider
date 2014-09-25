using System;
using System.Globalization;
using System.Net.Http;
using Microsoft.Owin;
using Microsoft.Owin.Logging;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.DataHandler;
using Microsoft.Owin.Security.DataProtection;
using Microsoft.Owin.Security.Infrastructure;
using Owin;

namespace Salesforce.Owin.Security.Provider
{
    public class SalesforceAuthenticationMiddleware : AuthenticationMiddleware<SalesforceAuthenticationOptions>
    {
        private readonly HttpClient httpClient;
        private readonly ILogger logger;

        public SalesforceAuthenticationMiddleware(OwinMiddleware next, IAppBuilder app,
            SalesforceAuthenticationOptions options)
            : base(next, options)
        {

            if (String.IsNullOrWhiteSpace(Options.ClientId))
                throw new ArgumentException(String.Format(CultureInfo.CurrentCulture,
                    "The '{0}' option must be provided.", "ClientId"));
            if (String.IsNullOrWhiteSpace(Options.ClientSecret))
                throw new ArgumentException(String.Format(CultureInfo.CurrentCulture,
                    "The '{0}' option must be provided.", "ClientSecret"));

            logger = app.CreateLogger<SalesforceAuthenticationMiddleware>();

            if (Options.Provider == null)
                Options.Provider = new SalesforceAuthenticationProvider();

            if (Options.StateDataFormat == null)
            {
                IDataProtector dataProtector = app.CreateDataProtector(
                    typeof(SalesforceAuthenticationMiddleware).FullName,
                    Options.AuthenticationType, "v1");
                Options.StateDataFormat = new PropertiesDataFormat(dataProtector);
            }

            if (String.IsNullOrEmpty(Options.SignInAsAuthenticationType))
                Options.SignInAsAuthenticationType = app.GetDefaultSignInAsAuthenticationType();

            httpClient = new HttpClient(ResolveHttpMessageHandler(Options))
            {
                Timeout = Options.BackchannelTimeout,
                MaxResponseContentBufferSize = 1024*1024*10,
            };
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("Microsoft Owin Salesforce middleware");
            httpClient.DefaultRequestHeaders.ExpectContinue = false;
        }

        protected override AuthenticationHandler<SalesforceAuthenticationOptions> CreateHandler()
        {
            return new SalesforceAuthenticationHandler(httpClient, logger);
        }

        private HttpMessageHandler ResolveHttpMessageHandler(SalesforceAuthenticationOptions options)
        {
            HttpMessageHandler handler = options.BackchannelHttpHandler ?? new WebRequestHandler();

            // If they provided a validator, apply it or fail.
            if (options.BackchannelCertificateValidator != null)
            {
                // Set the cert validate callback
                var webRequestHandler = handler as WebRequestHandler;
                if (webRequestHandler == null)
                {
                    throw new InvalidOperationException("An ICertificateValidator cannot be specified at the same time as an HttpMessageHandler unless it is a WebRequestHandler.");
                }
                webRequestHandler.ServerCertificateValidationCallback = options.BackchannelCertificateValidator.Validate;
            }

            return handler;
        }
    }
}