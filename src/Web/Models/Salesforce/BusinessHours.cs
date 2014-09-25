using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class BusinessHours
    {
        [Key]
        public string Id { get; set; }

        [StringLength(80)]
        public string Name { get; set; }

        public bool IsActive { get; set; }

        public bool IsDefault { get; set; }

        public DateTimeOffset? SundayStartTime { get; set; }

        public DateTimeOffset? SundayEndTime { get; set; }

        public DateTimeOffset? MondayStartTime { get; set; }

        public DateTimeOffset? MondayEndTime { get; set; }

        public DateTimeOffset? TuesdayStartTime { get; set; }

        public DateTimeOffset? TuesdayEndTime { get; set; }

        public DateTimeOffset? WednesdayStartTime { get; set; }

        public DateTimeOffset? WednesdayEndTime { get; set; }

        public DateTimeOffset? ThursdayStartTime { get; set; }

        public DateTimeOffset? ThursdayEndTime { get; set; }

        public DateTimeOffset? FridayStartTime { get; set; }

        public DateTimeOffset? FridayEndTime { get; set; }

        public DateTimeOffset? SaturdayStartTime { get; set; }

        public DateTimeOffset? SaturdayEndTime { get; set; }

        public string TimeZoneSidKey { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

    }
}
