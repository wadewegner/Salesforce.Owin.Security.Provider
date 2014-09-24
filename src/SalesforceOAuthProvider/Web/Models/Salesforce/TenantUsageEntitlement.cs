using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class TenantUsageEntitlement
    {
        [Key]
        public string Id { get; set; }

        public bool IsDeleted { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        [StringLength(120)]
        public string ResourceGroupKey { get; set; }

        [StringLength(120)]
        public string Setting { get; set; }

        public DateTimeOffset StartDate { get; set; }

        public DateTimeOffset? EndDate { get; set; }

        public double CurrentAmountAllowed { get; set; }

        public string Frequency { get; set; }

        public bool IsPersistentResource { get; set; }

        public bool HasRollover { get; set; }

        public double? OverageGrace { get; set; }

        [StringLength(255)]
        public string MasterLabel { get; set; }

    }
}
