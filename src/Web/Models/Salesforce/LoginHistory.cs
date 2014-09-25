using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class LoginHistory
    {
        [Key]
        public string Id { get; set; }

        public string UserId { get; set; }

        public DateTimeOffset LoginTime { get; set; }

        public string LoginType { get; set; }

        [StringLength(39)]
        public string SourceIp { get; set; }

        [StringLength(120)]
        public string LoginUrl { get; set; }

        [StringLength(64)]
        public string Browser { get; set; }

        [StringLength(64)]
        public string Platform { get; set; }

        [StringLength(128)]
        public string Status { get; set; }

        [StringLength(64)]
        public string Application { get; set; }

        [StringLength(64)]
        public string ClientVersion { get; set; }

        [StringLength(64)]
        public string ApiType { get; set; }

        [StringLength(32)]
        public string ApiVersion { get; set; }

    }
}
