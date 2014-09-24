using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class Event
    {
        [Key]
        public string Id { get; set; }

        public string WhoId { get; set; }

        public string WhatId { get; set; }

        public string Subject { get; set; }

        [StringLength(255)]
        public string Location { get; set; }

        public bool IsAllDayEvent { get; set; }

        public DateTimeOffset? ActivityDateTime { get; set; }

        public DateTimeOffset? ActivityDate { get; set; }

        public int? DurationInMinutes { get; set; }

        public DateTimeOffset? StartDateTime { get; set; }

        public DateTimeOffset? EndDateTime { get; set; }

        public string Description { get; set; }

        public string AccountId { get; set; }

        public string OwnerId { get; set; }

        public bool IsPrivate { get; set; }

        public string ShowAs { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsChild { get; set; }

        public bool IsGroupEvent { get; set; }

        public string GroupEventType { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        public bool IsArchived { get; set; }

        public string RecurrenceActivityId { get; set; }

        public bool IsRecurrence { get; set; }

        public DateTimeOffset? RecurrenceStartDateTime { get; set; }

        public DateTimeOffset? RecurrenceEndDateOnly { get; set; }

        public string RecurrenceTimeZoneSidKey { get; set; }

        public string RecurrenceType { get; set; }

        public int? RecurrenceInterval { get; set; }

        public int? RecurrenceDayOfWeekMask { get; set; }

        public int? RecurrenceDayOfMonth { get; set; }

        public string RecurrenceInstance { get; set; }

        public string RecurrenceMonthOfYear { get; set; }

        public DateTimeOffset? ReminderDateTime { get; set; }

        public bool IsReminderSet { get; set; }

    }
}
