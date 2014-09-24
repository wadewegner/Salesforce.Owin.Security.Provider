using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class OpportunityLineItem
    {
        [Key]
        public string Id { get; set; }

        public string OpportunityId { get; set; }

        public int? SortOrder { get; set; }

        public string PricebookEntryId { get; set; }

        public string Product2Id { get; set; }

        [StringLength(255)]
        public string ProductCode { get; set; }

        [StringLength(376)]
        public string Name { get; set; }

        public double Quantity { get; set; }

        public double? TotalPrice { get; set; }

        public double? UnitPrice { get; set; }

        public double? ListPrice { get; set; }

        public DateTimeOffset? ServiceDate { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        public bool IsDeleted { get; set; }

    }
}
