using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class PricebookEntry
    {
        [Key]
        public string Id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public string Pricebook2Id { get; set; }

        public string Product2Id { get; set; }

        public double UnitPrice { get; set; }

        public bool IsActive { get; set; }

        public bool UseStandardPrice { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        [StringLength(255)]
        public string ProductCode { get; set; }

        public bool IsDeleted { get; set; }

    }
}
