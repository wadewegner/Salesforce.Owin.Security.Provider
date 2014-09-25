using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class DatacloudSocialHandle
    {
        [Key]
        public string Id { get; set; }

        [StringLength(255)]
        public string ExternalId { get; set; }

        [StringLength(255)]
        public string DatacloudContactId { get; set; }

        [StringLength(255)]
        public string SocialId { get; set; }

        [StringLength(255)]
        public string ProviderName { get; set; }

        [Url]
        public string Url { get; set; }

    }
}
