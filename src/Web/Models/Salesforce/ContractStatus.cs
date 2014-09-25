using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class ContractStatus
    {
        [Key]
        public string Id { get; set; }

        [StringLength(255)]
        public string MasterLabel { get; set; }

        public int? SortOrder { get; set; }

        public bool IsDefault { get; set; }

        public string StatusCode { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

    }
}
