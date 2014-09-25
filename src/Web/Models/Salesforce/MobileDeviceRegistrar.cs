using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class MobileDeviceRegistrar
    {
        [Key]
        public string Id { get; set; }

        public bool IsDeleted { get; set; }

        [StringLength(80)]
        public string DeveloperName { get; set; }

        public string Language { get; set; }

        [StringLength(80)]
        public string MasterLabel { get; set; }

        [StringLength(15)]
        public string NamespacePrefix { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        public string Provider { get; set; }

        [Url]
        public string MdmProviderEnrollEndpoint { get; set; }

        [Url]
        public string MdmProviderPushAppEndpoint { get; set; }

        [StringLength(255)]
        public string MdmProviderApiAccessToken { get; set; }

        [StringLength(255)]
        public string MdmProviderApiUsername { get; set; }

        [StringLength(255)]
        public string MdmProviderApiPassword { get; set; }

    }
}
