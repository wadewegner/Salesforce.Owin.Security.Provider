using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class CronTrigger
    {
        [Key]
        public string Id { get; set; }

        public string CronJobDetailId { get; set; }

        public DateTimeOffset? NextFireTime { get; set; }

        public DateTimeOffset? PreviousFireTime { get; set; }

        [StringLength(16)]
        public string State { get; set; }

        public DateTimeOffset? StartTime { get; set; }

        public DateTimeOffset? EndTime { get; set; }

        [StringLength(255)]
        public string CronExpression { get; set; }

        public string TimeZoneSidKey { get; set; }

        public string OwnerId { get; set; }

        public string LastModifiedById { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public int? TimesTriggered { get; set; }

    }
}
