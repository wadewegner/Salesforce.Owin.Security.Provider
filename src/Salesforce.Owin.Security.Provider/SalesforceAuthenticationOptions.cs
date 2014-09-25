using System;
using System.Collections.Generic;
using System.Net.Http;
using Microsoft.Owin;
using Microsoft.Owin.Security;

namespace Salesforce.Owin.Security.Provider
{
    public class SalesforceAuthenticationOptions : AuthenticationOptions
    {
        public class SalesforceAuthenticationEndpoints
        {
            public string AuthorizationEndpoint { get; set; }
            public string TokenEndpoint { get; set; }
        }

        private const string AuthorizationEndPoint = "https://login.salesforce.com/services/oauth2/authorize";
        private const string TokenEndpoint = "https://login.salesforce.com/services/oauth2/token";

        public ICertificateValidator BackchannelCertificateValidator { get; set; }
        public HttpMessageHandler BackchannelHttpHandler { get; set; }
        public TimeSpan BackchannelTimeout { get; set; }
        public PathString CallbackPath { get; set; }

        public string Caption
        {
            get { return Description.Caption; }
            set { Description.Caption = value; }
        }

        public string ClientId { get; set; }
        public string ClientSecret { get; set; }

        public SalesforceAuthenticationEndpoints Endpoints { get; set; }
        public ISalesforceAuthenticationProvider Provider { get; set; }
        public IList<string> Scope { get; private set; }

        public string SignInAsAuthenticationType { get; set; }

        public ISecureDataFormat<AuthenticationProperties> StateDataFormat { get; set; }

        public SalesforceAuthenticationOptions()
            : base("Salesforce")
        {
            Caption = "Salesforce";
            CallbackPath = new PathString("/signin-salesforce");
            AuthenticationMode = AuthenticationMode.Passive;
            Scope = new List<string>
            {
                "user"
            };
            BackchannelTimeout = TimeSpan.FromSeconds(60);
            Endpoints = new SalesforceAuthenticationEndpoints
            {
                AuthorizationEndpoint = AuthorizationEndPoint,
                TokenEndpoint = TokenEndpoint
            };
        }
    }
}