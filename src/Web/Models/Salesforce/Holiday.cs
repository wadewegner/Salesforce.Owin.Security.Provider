using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class Holiday
    {
        [Key]
        public string Id { get; set; }

        [StringLength(80)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public bool IsAllDay { get; set; }

        public DateTimeOffset? ActivityDate { get; set; }

        public int? StartTimeInMinutes { get; set; }

        public int? EndTimeInMinutes { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        public bool IsRecurrence { get; set; }

        public DateTimeOffset? RecurrenceStartDate { get; set; }

        public DateTimeOffset? RecurrenceEndDateOnly { get; set; }

        public string RecurrenceType { get; set; }

        public int? RecurrenceInterval { get; set; }

        public int? RecurrenceDayOfWeekMask { get; set; }

        public int? RecurrenceDayOfMonth { get; set; }

        public string RecurrenceInstance { get; set; }

        public string RecurrenceMonthOfYear { get; set; }

    }
}
