using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class DatacloudCompany
    {
        [Key]
        public string Id { get; set; }

        [StringLength(255)]
        public string ExternalId { get; set; }

        [StringLength(25)]
        public string CompanyId { get; set; }

        [StringLength(128)]
        public string Name { get; set; }

        [StringLength(400)]
        public string Description { get; set; }

        public bool IsInactive { get; set; }

        [Phone]
        public string Phone { get; set; }

        [Phone]
        public string Fax { get; set; }

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

        [StringLength(128)]
        public string Site { get; set; }

        [StringLength(128)]
        public string Industry { get; set; }

        public int? NumberOfEmployees { get; set; }

        public double? AnnualRevenue { get; set; }

        [StringLength(128)]
        public string DunsNumber { get; set; }

        [StringLength(128)]
        public string NaicsCode { get; set; }

        [StringLength(128)]
        public string NaicsDesc { get; set; }

        [StringLength(128)]
        public string Sic { get; set; }

        [StringLength(128)]
        public string SicDesc { get; set; }

        [StringLength(16)]
        public string Ownership { get; set; }

        public bool IsOwned { get; set; }

        [StringLength(16)]
        public string TickerSymbol { get; set; }

        [StringLength(128)]
        public string TradeStyle { get; set; }

        [Url]
        public string Website { get; set; }

        [StringLength(4)]
        public string YearStarted { get; set; }

        public int? ActiveContacts { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }

    }
}
