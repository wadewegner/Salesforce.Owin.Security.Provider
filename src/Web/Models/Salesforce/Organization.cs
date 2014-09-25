using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class Organization
    {
        [Key]
        public string Id { get; set; }

        [StringLength(80)]
        public string Name { get; set; }

        [StringLength(80)]
        public string Division { get; set; }

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
        public string Fax { get; set; }

        [StringLength(80)]
        public string PrimaryContact { get; set; }

        public string DefaultLocaleSidKey { get; set; }

        public string LanguageLocaleKey { get; set; }

        public bool ReceivesInfoEmails { get; set; }

        public bool ReceivesAdminInfoEmails { get; set; }

        public bool PreferencesRequireOpportunityProducts { get; set; }

        public int? FiscalYearStartMonth { get; set; }

        public bool UsesStartDateAsFiscalYearName { get; set; }

        public string DefaultAccountAccess { get; set; }

        public string DefaultContactAccess { get; set; }

        public string DefaultOpportunityAccess { get; set; }

        public string DefaultLeadAccess { get; set; }

        public string DefaultCaseAccess { get; set; }

        public string DefaultCalendarAccess { get; set; }

        public string DefaultPricebookAccess { get; set; }

        public string DefaultCampaignAccess { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        [EmailAddress]
        public string ComplianceBccEmail { get; set; }

        public string UiSkin { get; set; }

        public DateTimeOffset? TrialExpirationDate { get; set; }

        public string OrganizationType { get; set; }

        [StringLength(40)]
        public string WebToCaseDefaultOrigin { get; set; }

        public int? MonthlyPageViewsUsed { get; set; }

        public int? MonthlyPageViewsEntitlement { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

    }
}
