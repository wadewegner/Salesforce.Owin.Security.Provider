using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class ApexTrigger
    {
        [Key]
        public string Id { get; set; }

        [StringLength(15)]
        public string NamespacePrefix { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public string TableEnumOrId { get; set; }

        public bool UsageBeforeInsert { get; set; }

        public bool UsageAfterInsert { get; set; }

        public bool UsageBeforeUpdate { get; set; }

        public bool UsageAfterUpdate { get; set; }

        public bool UsageBeforeDelete { get; set; }

        public bool UsageAfterDelete { get; set; }

        public bool UsageIsBulk { get; set; }

        public bool UsageAfterUndelete { get; set; }

        public double ApiVersion { get; set; }

        public string Status { get; set; }

        public bool IsValid { get; set; }

        public double? BodyCrc { get; set; }

        public string Body { get; set; }

        public int LengthWithoutComments { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

    }
}
