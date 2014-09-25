using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class Campaign
    {
        [Key]
        public string Id { get; set; }

        public bool IsDeleted { get; set; }

        [StringLength(80)]
        public string Name { get; set; }

        public string ParentId { get; set; }

        public string Type { get; set; }

        public string Status { get; set; }

        public DateTimeOffset? StartDate { get; set; }

        public DateTimeOffset? EndDate { get; set; }

        public double? ExpectedRevenue { get; set; }

        public double? BudgetedCost { get; set; }

        public double? ActualCost { get; set; }

        public double? ExpectedResponse { get; set; }

        public double? NumberSent { get; set; }

        public bool IsActive { get; set; }

        public string Description { get; set; }

        public int NumberOfLeads { get; set; }

        public int NumberOfConvertedLeads { get; set; }

        public int NumberOfContacts { get; set; }

        public int NumberOfResponses { get; set; }

        public int NumberOfOpportunities { get; set; }

        public int NumberOfWonOpportunities { get; set; }

        public double AmountAllOpportunities { get; set; }

        public double AmountWonOpportunities { get; set; }

        public string OwnerId { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        public DateTimeOffset? LastActivityDate { get; set; }

        public DateTimeOffset? LastViewedDate { get; set; }

        public DateTimeOffset? LastReferencedDate { get; set; }

        public string CampaignMemberRecordTypeId { get; set; }

    }
}
