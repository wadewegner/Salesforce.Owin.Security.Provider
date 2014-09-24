using System.Threading.Tasks;

namespace Salesforce.OWIN.Security.Provider
{
    public interface ISalesforceAuthenticationProvider
    {
        Task Authenticated(SalesforceAuthenticatedContext context);
        Task ReturnEndpoint(SalesforceReturnEndpointContext context);
    }
}