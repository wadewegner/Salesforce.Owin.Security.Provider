using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class AccountCleanInfo
    {
        [Key]
        public string Id { get; set; }

        public bool IsDeleted { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        public string AccountId { get; set; }

        public DateTimeOffset LastMatchedDate { get; set; }

        public DateTimeOffset? LastStatusChangedDate { get; set; }

        public string LastStatusChangedById { get; set; }

        public bool IsInactive { get; set; }

        [StringLength(255)]
        public string CompanyName { get; set; }

        [Phone]
        public string Phone { get; set; }

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

        [Url]
        public string Website { get; set; }

        [StringLength(20)]
        public string TickerSymbol { get; set; }

        public double? AnnualRevenue { get; set; }

        public int? NumberOfEmployees { get; set; }

        public string Industry { get; set; }

        public string Ownership { get; set; }

        [StringLength(9)]
        public string DunsNumber { get; set; }

        [StringLength(20)]
        public string Sic { get; set; }

        [StringLength(80)]
        public string SicDescription { get; set; }

        [StringLength(8)]
        public string NaicsCode { get; set; }

        [StringLength(120)]
        public string NaicsDescription { get; set; }

        [StringLength(12)]
        public string YearStarted { get; set; }

        [Phone]
        public string Fax { get; set; }

        [StringLength(80)]
        public string AccountSite { get; set; }

        public string Description { get; set; }

        [StringLength(255)]
        public string Tradestyle { get; set; }

        [StringLength(9)]
        public string DandBCompanyDunsNumber { get; set; }

        [StringLength(255)]
        public string DunsRightMatchGrade { get; set; }

        public int? DunsRightMatchConfidence { get; set; }

        public string CompanyStatusDataDotCom { get; set; }

        public bool IsReviewedCompanyName { get; set; }

        public bool IsReviewedPhone { get; set; }

        public bool IsReviewedAddress { get; set; }

        public bool IsReviewedWebsite { get; set; }

        public bool IsReviewedTickerSymbol { get; set; }

        public bool IsReviewedAnnualRevenue { get; set; }

        public bool IsReviewedNumberOfEmployees { get; set; }

        public bool IsReviewedIndustry { get; set; }

        public bool IsReviewedOwnership { get; set; }

        public bool IsReviewedDunsNumber { get; set; }

        public bool IsReviewedSic { get; set; }

        public bool IsReviewedSicDescription { get; set; }

        public bool IsReviewedNaicsCode { get; set; }

        public bool IsReviewedNaicsDescription { get; set; }

        public bool IsReviewedYearStarted { get; set; }

        public bool IsReviewedFax { get; set; }

        public bool IsReviewedAccountSite { get; set; }

        public bool IsReviewedDescription { get; set; }

        public bool IsReviewedTradestyle { get; set; }

        public bool IsReviewedDandBCompanyDunsNumber { get; set; }

        public bool IsDifferentCompanyName { get; set; }

        public bool IsDifferentPhone { get; set; }

        public bool IsDifferentStreet { get; set; }

        public bool IsDifferentCity { get; set; }

        public bool IsDifferentState { get; set; }

        public bool IsDifferentPostalCode { get; set; }

        public bool IsDifferentCountry { get; set; }

        public bool IsDifferentWebsite { get; set; }

        public bool IsDifferentTickerSymbol { get; set; }

        public bool IsDifferentAnnualRevenue { get; set; }

        public bool IsDifferentNumberOfEmployees { get; set; }

        public bool IsDifferentIndustry { get; set; }

        public bool IsDifferentOwnership { get; set; }

        public bool IsDifferentDunsNumber { get; set; }

        public bool IsDifferentSic { get; set; }

        public bool IsDifferentSicDescription { get; set; }

        public bool IsDifferentNaicsCode { get; set; }

        public bool IsDifferentNaicsDescription { get; set; }

        public bool IsDifferentYearStarted { get; set; }

        public bool IsDifferentFax { get; set; }

        public bool IsDifferentAccountSite { get; set; }

        public bool IsDifferentDescription { get; set; }

        public bool IsDifferentTradestyle { get; set; }

        public bool IsDifferentDandBCompanyDunsNumber { get; set; }

        public bool IsDifferentStateCode { get; set; }

        public bool IsDifferentCountryCode { get; set; }

        public bool CleanedByJob { get; set; }

        public bool CleanedByUser { get; set; }

        public bool IsFlaggedWrongCompanyName { get; set; }

        public bool IsFlaggedWrongPhone { get; set; }

        public bool IsFlaggedWrongAddress { get; set; }

        public bool IsFlaggedWrongWebsite { get; set; }

        public bool IsFlaggedWrongTickerSymbol { get; set; }

        public bool IsFlaggedWrongAnnualRevenue { get; set; }

        public bool IsFlaggedWrongNumberOfEmployees { get; set; }

        public bool IsFlaggedWrongIndustry { get; set; }

        public bool IsFlaggedWrongOwnership { get; set; }

        public bool IsFlaggedWrongDunsNumber { get; set; }

        public bool IsFlaggedWrongSic { get; set; }

        public bool IsFlaggedWrongSicDescription { get; set; }

        public bool IsFlaggedWrongNaicsCode { get; set; }

        public bool IsFlaggedWrongNaicsDescription { get; set; }

        public bool IsFlaggedWrongYearStarted { get; set; }

        public bool IsFlaggedWrongFax { get; set; }

        public bool IsFlaggedWrongAccountSite { get; set; }

        public bool IsFlaggedWrongDescription { get; set; }

        public bool IsFlaggedWrongTradestyle { get; set; }

        [StringLength(20)]
        public string DataDotComId { get; set; }

    }
}
