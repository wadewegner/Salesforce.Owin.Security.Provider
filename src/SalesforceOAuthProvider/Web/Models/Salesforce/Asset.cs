using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class Asset
    {
        [Key]
        public string Id { get; set; }

        public string ContactId { get; set; }

        public string AccountId { get; set; }

        public string Product2Id { get; set; }

        public bool IsCompetitorProduct { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        public bool IsDeleted { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(80)]
        public string SerialNumber { get; set; }

        public DateTimeOffset? InstallDate { get; set; }

        public DateTimeOffset? PurchaseDate { get; set; }

        public DateTimeOffset? UsageEndDate { get; set; }

        public string Status { get; set; }

        public double? Price { get; set; }

        public double? Quantity { get; set; }

        public string Description { get; set; }

    }
}
