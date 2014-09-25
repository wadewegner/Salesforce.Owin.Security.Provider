using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class Case
    {
        [Key]
        public string Id { get; set; }

        public bool IsDeleted { get; set; }

        [StringLength(30)]
        public string CaseNumber { get; set; }

        public string ContactId { get; set; }

        public string AccountId { get; set; }

        public string AssetId { get; set; }

        public string ParentId { get; set; }

        [StringLength(80)]
        public string SuppliedName { get; set; }

        [EmailAddress]
        public string SuppliedEmail { get; set; }

        [StringLength(40)]
        public string SuppliedPhone { get; set; }

        [StringLength(80)]
        public string SuppliedCompany { get; set; }

        public string Type { get; set; }

        public string Status { get; set; }

        public string Reason { get; set; }

        public string Origin { get; set; }

        [StringLength(255)]
        public string Subject { get; set; }

        public string Priority { get; set; }

        public string Description { get; set; }

        public bool IsClosed { get; set; }

        public DateTimeOffset? ClosedDate { get; set; }

        public bool IsEscalated { get; set; }

        public string OwnerId { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        public DateTimeOffset? LastViewedDate { get; set; }

        public DateTimeOffset? LastReferencedDate { get; set; }

        [StringLength(12)]
        public string EngineeringReqNumber__c { get; set; }

        public string SLAViolation__c { get; set; }

        public string Product__c { get; set; }

        public string PotentialLiability__c { get; set; }

    }
}
