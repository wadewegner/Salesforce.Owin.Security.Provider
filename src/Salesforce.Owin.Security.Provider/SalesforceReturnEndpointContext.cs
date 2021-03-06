using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Provider;

namespace Salesforce.Owin.Security.Provider
{
    public class SalesforceReturnEndpointContext : ReturnEndpointContext
    {
        public SalesforceReturnEndpointContext(
            IOwinContext context,
            AuthenticationTicket ticket)
            : base(context, ticket)
        {
        }
    }
}
