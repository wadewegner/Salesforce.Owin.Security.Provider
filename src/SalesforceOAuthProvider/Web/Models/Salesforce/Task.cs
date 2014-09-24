using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class Task
    {
        [Key]
        public string Id { get; set; }

        public string WhoId { get; set; }

        public string WhatId { get; set; }

        public string Subject { get; set; }

        public DateTimeOffset? ActivityDate { get; set; }

        public string Status { get; set; }

        public string Priority { get; set; }

        public string OwnerId { get; set; }

        public string Description { get; set; }

        public bool IsDeleted { get; set; }

        public string AccountId { get; set; }

        public bool IsClosed { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        public bool IsArchived { get; set; }

        public int? CallDurationInSeconds { get; set; }

        public string CallType { get; set; }

        [StringLength(255)]
        public string CallDisposition { get; set; }

        [StringLength(255)]
        public string CallObject { get; set; }

        public DateTimeOffset? ReminderDateTime { get; set; }

        public bool IsReminderSet { get; set; }

        public string RecurrenceActivityId { get; set; }

        public bool IsRecurrence { get; set; }

        public DateTimeOffset? RecurrenceStartDateOnly { get; set; }

        public DateTimeOffset? RecurrenceEndDateOnly { get; set; }

        public string RecurrenceTimeZoneSidKey { get; set; }

        public string RecurrenceType { get; set; }

        public int? RecurrenceInterval { get; set; }

        public int? RecurrenceDayOfWeekMask { get; set; }

        public int? RecurrenceDayOfMonth { get; set; }

        public string RecurrenceInstance { get; set; }

        public string RecurrenceMonthOfYear { get; set; }

        public string RecurrenceRegeneratedType { get; set; }

    }
}
