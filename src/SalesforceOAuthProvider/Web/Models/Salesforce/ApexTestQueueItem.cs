using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class ApexTestQueueItem
    {
        [Key]
        public string Id { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        public string ApexClassId { get; set; }

        public string Status { get; set; }

        [StringLength(1000)]
        public string ExtendedStatus { get; set; }

        public string ParentJobId { get; set; }

    }
}
