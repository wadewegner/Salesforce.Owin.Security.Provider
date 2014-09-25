using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class Lead
    {
        [Key]
        public string Id { get; set; }

        public bool IsDeleted { get; set; }

        public string MasterRecordId { get; set; }

        [StringLength(80)]
        public string LastName { get; set; }

        [StringLength(40)]
        public string FirstName { get; set; }

        public string Salutation { get; set; }

        [StringLength(121)]
        public string Name { get; set; }

        [StringLength(128)]
        public string Title { get; set; }

        [StringLength(255)]
        public string Company { get; set; }

        public string Street { get; set; }

        [StringLength(40)]
        public string City { get; set; }

        [StringLength(80)]
        public string State { get; set; }

        [StringLength(20)]
        public string PostalCode { get; set; }

        [StringLength(80)]
        public string Country { get; set; }

        public double? Latitude { get; set; }

        public double? Longitude { get; set; }

        [Phone]
        public string Phone { get; set; }

        [Phone]
        public string MobilePhone { get; set; }

        [Phone]
        public string Fax { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Url]
        public string Website { get; set; }

        [Url]
        public string PhotoUrl { get; set; }

        public string Description { get; set; }

        public string LeadSource { get; set; }

        public string Status { get; set; }

        public string Industry { get; set; }

        public string Rating { get; set; }

        public double? AnnualRevenue { get; set; }

        public int? NumberOfEmployees { get; set; }

        public string OwnerId { get; set; }

        public bool IsConverted { get; set; }

        public DateTimeOffset? ConvertedDate { get; set; }

        public string ConvertedAccountId { get; set; }

        public string ConvertedContactId { get; set; }

        public string ConvertedOpportunityId { get; set; }

        public bool IsUnreadByOwner { get; set; }

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
        public string JigsawContactId { get; set; }

        public string CleanStatus { get; set; }

        [StringLength(9)]
        public string CompanyDunsNumber { get; set; }

        public string DandbCompanyId { get; set; }

        [StringLength(255)]
        public string EmailBouncedReason { get; set; }

        public DateTimeOffset? EmailBouncedDate { get; set; }

        [StringLength(15)]
        public string SICCode__c { get; set; }

        public string ProductInterest__c { get; set; }

        public string Primary__c { get; set; }

        [StringLength(100)]
        public string CurrentGenerators__c { get; set; }

        public double? NumberofLocations__c { get; set; }

    }
}
