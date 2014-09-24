using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class ProcessInstanceHistory
    {
        [Key]
        public string Id { get; set; }

        public bool IsPending { get; set; }

        public string ProcessInstanceId { get; set; }

        public string TargetObjectId { get; set; }

        public string StepStatus { get; set; }

        public string OriginalActorId { get; set; }

        public string ActorId { get; set; }

        public int? RemindersSent { get; set; }

        [StringLength(4000)]
        public string Comments { get; set; }

        public bool IsDeleted { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

    }
}
