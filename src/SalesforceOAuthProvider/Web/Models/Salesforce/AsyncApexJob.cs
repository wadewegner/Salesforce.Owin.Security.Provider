using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class AsyncApexJob
    {
        [Key]
        public string Id { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public string JobType { get; set; }

        public string ApexClassId { get; set; }

        public string Status { get; set; }

        public int JobItemsProcessed { get; set; }

        public int? TotalJobItems { get; set; }

        public int? NumberOfErrors { get; set; }

        public DateTimeOffset? CompletedDate { get; set; }

        [StringLength(255)]
        public string MethodName { get; set; }

        [StringLength(255)]
        public string ExtendedStatus { get; set; }

        public string ParentJobId { get; set; }

        [StringLength(15)]
        public string LastProcessed { get; set; }

        public int? LastProcessedOffset { get; set; }

    }
}
