using System.Threading.Tasks;

namespace Salesforce.Owin.Security.Provider
{
    public interface ISalesforceAuthenticationProvider
    {
        Task Authenticated(SalesforceAuthenticatedContext context);
        Task ReturnEndpoint(SalesforceReturnEndpointContext context);
    }
}