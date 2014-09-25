using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class AuthProvider
    {
        [Key]
        public string Id { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string ProviderType { get; set; }

        [StringLength(32)]
        public string FriendlyName { get; set; }

        [StringLength(32)]
        public string DeveloperName { get; set; }

        public string RegistrationHandlerId { get; set; }

        public string ExecutionUserId { get; set; }

        [StringLength(256)]
        public string ConsumerKey { get; set; }

        [StringLength(100)]
        public string ConsumerSecret { get; set; }

        [StringLength(500)]
        public string ErrorUrl { get; set; }

        [Url]
        public string AuthorizeUrl { get; set; }

        [Url]
        public string TokenUrl { get; set; }

        [Url]
        public string UserInfoUrl { get; set; }

        [StringLength(256)]
        public string DefaultScopes { get; set; }

        [StringLength(1024)]
        public string IdTokenIssuer { get; set; }

        public bool OptionsSendAccessTokenInHeader { get; set; }

        public bool OptionsSendClientCredentialsInHeader { get; set; }

    }
}
