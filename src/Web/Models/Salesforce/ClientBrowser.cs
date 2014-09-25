using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class ClientBrowser
    {
        [Key]
        public string Id { get; set; }

        public string UsersId { get; set; }

        [StringLength(1024)]
        public string FullUserAgent { get; set; }

        [StringLength(1024)]
        public string ProxyInfo { get; set; }

        public DateTimeOffset? LastUpdate { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

    }
}
