using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class ApexLog
    {
        [Key]
        public string Id { get; set; }

        public string LogUserId { get; set; }

        public int LogLength { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        [StringLength(16)]
        public string Request { get; set; }

        [StringLength(128)]
        public string Operation { get; set; }

        [StringLength(64)]
        public string Application { get; set; }

        [StringLength(255)]
        public string Status { get; set; }

        public int DurationMilliseconds { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        public DateTimeOffset StartTime { get; set; }

        public string Location { get; set; }

    }
}
