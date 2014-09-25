using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class ProcessInstanceStep
    {
        [Key]
        public string Id { get; set; }

        public string ProcessInstanceId { get; set; }

        public string StepStatus { get; set; }

        public string OriginalActorId { get; set; }

        public string ActorId { get; set; }

        [StringLength(4000)]
        public string Comments { get; set; }

        public string StepNodeId { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

    }
}
