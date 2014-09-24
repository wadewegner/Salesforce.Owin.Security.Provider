using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class DatacloudDandBCompany
    {
        [Key]
        public string Id { get; set; }

        [StringLength(255)]
        public string ExternalId { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(9)]
        public string DunsNumber { get; set; }

        [StringLength(25)]
        public string CompanyId { get; set; }

        [StringLength(255)]
        public string Street { get; set; }

        [StringLength(255)]
        public string City { get; set; }

        [StringLength(50)]
        public string State { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        [StringLength(32)]
        public string Zip { get; set; }

        [Phone]
        public string Phone { get; set; }

        [Phone]
        public string Fax { get; set; }

        [StringLength(4)]
        public string CountryAccessCode { get; set; }

        public string PublicIndicator { get; set; }

        [StringLength(6)]
        public string StockSymbol { get; set; }

        [StringLength(16)]
        public string StockExchange { get; set; }

        public double? SalesVolume { get; set; }

        [Url]
        public string URL { get; set; }

        public string OutOfBusiness { get; set; }

        public double? EmployeesTotal { get; set; }

        [StringLength(5)]
        public string FipsMsaCode { get; set; }

        [StringLength(255)]
        public string FipsMsaDesc { get; set; }

        [StringLength(255)]
        public string TradeStyle1 { get; set; }

        [StringLength(4)]
        public string YearStarted { get; set; }

        [StringLength(255)]
        public string MailingStreet { get; set; }

        [StringLength(255)]
        public string MailingCity { get; set; }

        [StringLength(50)]
        public string MailingState { get; set; }

        [StringLength(50)]
        public string MailingCountry { get; set; }

        [StringLength(32)]
        public string MailingZip { get; set; }

        [StringLength(11)]
        public string Latitude { get; set; }

        [StringLength(11)]
        public string Longitude { get; set; }

        [StringLength(4)]
        public string PrimarySic { get; set; }

        [StringLength(80)]
        public string PrimarySicDesc { get; set; }

        [StringLength(4)]
        public string SecondSic { get; set; }

        [StringLength(80)]
        public string SecondSicDesc { get; set; }

        [StringLength(4)]
        public string ThirdSic { get; set; }

        [StringLength(80)]
        public string ThirdSicDesc { get; set; }

        [StringLength(4)]
        public string FourthSic { get; set; }

        [StringLength(80)]
        public string FourthSicDesc { get; set; }

        [StringLength(4)]
        public string FifthSic { get; set; }

        [StringLength(80)]
        public string FifthSicDesc { get; set; }

        [StringLength(4)]
        public string SixthSic { get; set; }

        [StringLength(80)]
        public string SixthSicDesc { get; set; }

        [StringLength(6)]
        public string PrimaryNaics { get; set; }

        [StringLength(120)]
        public string PrimaryNaicsDesc { get; set; }

        [StringLength(6)]
        public string SecondNaics { get; set; }

        [StringLength(120)]
        public string SecondNaicsDesc { get; set; }

        [StringLength(6)]
        public string ThirdNaics { get; set; }

        [StringLength(120)]
        public string ThirdNaicsDesc { get; set; }

        [StringLength(6)]
        public string FourthNaics { get; set; }

        [StringLength(120)]
        public string FourthNaicsDesc { get; set; }

        [StringLength(6)]
        public string FifthNaics { get; set; }

        [StringLength(120)]
        public string FifthNaicsDesc { get; set; }

        [StringLength(6)]
        public string SixthNaics { get; set; }

        [StringLength(120)]
        public string SixthNaicsDesc { get; set; }

        public string OwnOrRent { get; set; }

        public double? EmployeesHere { get; set; }

        public string EmployeesHereReliability { get; set; }

        public string SalesVolumeReliability { get; set; }

        public string CurrencyCode { get; set; }

        public string LegalStatus { get; set; }

        public double? GlobalUltimateTotalEmployees { get; set; }

        public string EmployeesTotalReliability { get; set; }

        public string MinorityOwned { get; set; }

        public string WomenOwned { get; set; }

        public string SmallBusiness { get; set; }

        public string MarketingSegmentationCluster { get; set; }

        public string ImportExportAgent { get; set; }

        public string Subsidiary { get; set; }

        [StringLength(255)]
        public string TradeStyle2 { get; set; }

        [StringLength(255)]
        public string TradeStyle3 { get; set; }

        [StringLength(255)]
        public string TradeStyle4 { get; set; }

        [StringLength(255)]
        public string TradeStyle5 { get; set; }

        [StringLength(255)]
        public string NationalId { get; set; }

        public string NationalIdType { get; set; }

        [StringLength(9)]
        public string UsTaxId { get; set; }

        public string GeoCodeAccuracy { get; set; }

        public int? FamilyMembers { get; set; }

        public string MarketingPreScreen { get; set; }

        [StringLength(9)]
        public string GlobalUltimateDunsNumber { get; set; }

        [StringLength(255)]
        public string GlobalUltimateBusinessName { get; set; }

        [StringLength(9)]
        public string ParentOrHqDunsNumber { get; set; }

        [StringLength(255)]
        public string ParentOrHqBusinessName { get; set; }

        [StringLength(9)]
        public string DomesticUltimateDunsNumber { get; set; }

        [StringLength(255)]
        public string DomesticUltimateBusinessName { get; set; }

        public string LocationStatus { get; set; }

        public string CompanyCurrencyIsoCode { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

    }
}
