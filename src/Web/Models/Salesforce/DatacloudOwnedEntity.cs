using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class DatacloudOwnedEntity
    {
        [Key]
        public string Id { get; set; }

        public bool IsDeleted { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        [StringLength(25)]
        public string DataDotComKey { get; set; }

        public string DatacloudEntityType { get; set; }

        public string UserId { get; set; }

        public string PurchaseUsageId { get; set; }

        public string PurchaseType { get; set; }

    }
}
