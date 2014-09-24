using System.Security.Claims;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Provider;
using Newtonsoft.Json.Linq;

namespace Salesforce.OWIN.Security.Provider
{
    public class SalesforceAuthenticatedContext : BaseContext
    {
        public SalesforceAuthenticatedContext(IOwinContext context, JObject user, string accessToken, string refreshToken)
            : base(context)
        {
            User = user;
            AccessToken = accessToken;
            RefreshToken = refreshToken;

            Id = TryGetValue(user, "id");
            UserId = TryGetValue(user, "user_id");
            OrganizationId = TryGetValue(user, "organization_id");
            UserName = TryGetValue(user, "username");
            NickName = TryGetValue(user, "nick_name");
            DisplayName = TryGetValue(user, "display_name");
            Email = TryGetValue(user, "email");
            FirstName = TryGetValue(user, "first_name");
            LastName = TryGetValue(user, "last_name");
            TimeZone = TryGetValue(user, "timezone");
            Active = TryGetValue(user, "active");
        }

        public JObject User { get; private set; }
        public string AccessToken { get; private set; }
        public string RefreshToken { get; private set; }
        public string Id { get; private set; }
        public string UserId { get; private set; }
        public string OrganizationId { get; private set; }
        public string UserName { get; private set; }
        public string NickName { get; private set; }
        public string DisplayName { get; private set; }
        public string Email { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string TimeZone { get; private set; }
        public string Active { get; private set; }
        public ClaimsIdentity Identity { get; set; }
        public AuthenticationProperties Properties { get; set; }

        private static string TryGetValue(JObject user, string propertyName)
        {
            JToken value;
            return user.TryGetValue(propertyName, out value) ? value.ToString() : null;
        }
    }
}
