using System;
using System.Threading.Tasks;

namespace Salesforce.OWIN.Security.Provider
{
    public class SalesforceAuthenticationProvider : ISalesforceAuthenticationProvider
    {
        public SalesforceAuthenticationProvider()
        {
            OnAuthenticated = context => Task.FromResult<object>(null);
            OnReturnEndpoint = context => Task.FromResult<object>(null);
        }

        public Func<SalesforceAuthenticatedContext, Task> OnAuthenticated { get; set; }
        public Func<SalesforceReturnEndpointContext, Task> OnReturnEndpoint { get; set; }

        public virtual Task Authenticated(SalesforceAuthenticatedContext context)
        {
            return OnAuthenticated(context);
        }

        public virtual Task ReturnEndpoint(SalesforceReturnEndpointContext context)
        {
            return OnReturnEndpoint(context);
        }
    }
}