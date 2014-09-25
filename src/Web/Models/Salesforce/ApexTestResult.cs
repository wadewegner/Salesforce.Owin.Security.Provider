using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class ApexTestResult
    {
        [Key]
        public string Id { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        public DateTimeOffset TestTimestamp { get; set; }

        public string Outcome { get; set; }

        public string ApexClassId { get; set; }

        [StringLength(255)]
        public string MethodName { get; set; }

        [StringLength(4000)]
        public string Message { get; set; }

        [StringLength(4000)]
        public string StackTrace { get; set; }

        public string AsyncApexJobId { get; set; }

        public string QueueItemId { get; set; }

        public string ApexLogId { get; set; }

    }
}
