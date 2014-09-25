using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class Account
    {
        [Key]
        public string Id { get; set; }

        public bool IsDeleted { get; set; }

        public string MasterRecordId { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public string Type { get; set; }

        public string ParentId { get; set; }

        public string BillingStreet { get; set; }

        [StringLength(40)]
        public string BillingCity { get; set; }

        [StringLength(80)]
        public string BillingState { get; set; }

        [StringLength(20)]
        public string BillingPostalCode { get; set; }

        [StringLength(80)]
        public string BillingCountry { get; set; }

        public double? BillingLatitude { get; set; }

        public double? BillingLongitude { get; set; }

        public string ShippingStreet { get; set; }

        [StringLength(40)]
        public string ShippingCity { get; set; }

        [StringLength(80)]
        public string ShippingState { get; set; }

        [StringLength(20)]
        public string ShippingPostalCode { get; set; }

        [StringLength(80)]
        public string ShippingCountry { get; set; }

        public double? ShippingLatitude { get; set; }

        public double? ShippingLongitude { get; set; }

        [Phone]
        public string Phone { get; set; }

        [Phone]
        public string Fax { get; set; }

        [StringLength(40)]
        public string AccountNumber { get; set; }

        [Url]
        public string Website { get; set; }

        [Url]
        public string PhotoUrl { get; set; }

        [StringLength(20)]
        public string Sic { get; set; }

        public string Industry { get; set; }

        public double? AnnualRevenue { get; set; }

        public int? NumberOfEmployees { get; set; }

        public string Ownership { get; set; }

        [StringLength(20)]
        public string TickerSymbol { get; set; }

        public string Description { get; set; }

        public string Rating { get; set; }

        [StringLength(80)]
        public string Site { get; set; }

        public string OwnerId { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        public DateTimeOffset? LastActivityDate { get; set; }

        public DateTimeOffset? LastViewedDate { get; set; }

        public DateTimeOffset? LastReferencedDate { get; set; }

        [StringLength(20)]
        public string Jigsaw { get; set; }

        [StringLength(20)]
        public string JigsawCompanyId { get; set; }

        public string CleanStatus { get; set; }

        public string AccountSource { get; set; }

        [StringLength(9)]
        public string DunsNumber { get; set; }

        [StringLength(255)]
        public string Tradestyle { get; set; }

        [StringLength(8)]
        public string NaicsCode { get; set; }

        [StringLength(120)]
        public string NaicsDesc { get; set; }

        [StringLength(4)]
        public string YearStarted { get; set; }

        [StringLength(80)]
        public string SicDesc { get; set; }

        public string DandbCompanyId { get; set; }

        public string CustomerPriority__c { get; set; }

        public string SLA__c { get; set; }

        public string Active__c { get; set; }

        public double? NumberofLocations__c { get; set; }

        public string UpsellOpportunity__c { get; set; }

        [StringLength(10)]
        public string SLASerialNumber__c { get; set; }

        public DateTimeOffset? SLAExpirationDate__c { get; set; }

    }
}
