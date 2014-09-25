using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class Opportunity
    {
        [Key]
        public string Id { get; set; }

        public bool IsDeleted { get; set; }

        public string AccountId { get; set; }

        public bool IsPrivate { get; set; }

        [StringLength(120)]
        public string Name { get; set; }

        public string Description { get; set; }

        public string StageName { get; set; }

        public double? Amount { get; set; }

        public double? Probability { get; set; }

        public double? ExpectedRevenue { get; set; }

        public double? TotalOpportunityQuantity { get; set; }

        public DateTimeOffset CloseDate { get; set; }

        public string Type { get; set; }

        [StringLength(255)]
        public string NextStep { get; set; }

        public string LeadSource { get; set; }

        public bool IsClosed { get; set; }

        public bool IsWon { get; set; }

        public string ForecastCategory { get; set; }

        public string ForecastCategoryName { get; set; }

        public string CampaignId { get; set; }

        public bool HasOpportunityLineItem { get; set; }

        public string Pricebook2Id { get; set; }

        public string OwnerId { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        public DateTimeOffset? LastActivityDate { get; set; }

        public int? FiscalQuarter { get; set; }

        public int? FiscalYear { get; set; }

        [StringLength(6)]
        public string Fiscal { get; set; }

        public DateTimeOffset? LastViewedDate { get; set; }

        public DateTimeOffset? LastReferencedDate { get; set; }

        public string DeliveryInstallationStatus__c { get; set; }

        [StringLength(12)]
        public string TrackingNumber__c { get; set; }

        [StringLength(8)]
        public string OrderNumber__c { get; set; }

        [StringLength(100)]
        public string CurrentGenerators__c { get; set; }

        [StringLength(100)]
        public string MainCompetitors__c { get; set; }

    }
}
