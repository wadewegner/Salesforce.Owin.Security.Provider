using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class Contract
    {
        [Key]
        public string Id { get; set; }

        public string AccountId { get; set; }

        public string Pricebook2Id { get; set; }

        public string OwnerExpirationNotice { get; set; }

        public DateTimeOffset? StartDate { get; set; }

        public DateTimeOffset? EndDate { get; set; }

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

        public int? ContractTerm { get; set; }

        public string OwnerId { get; set; }

        public string Status { get; set; }

        public string CompanySignedId { get; set; }

        public DateTimeOffset? CompanySignedDate { get; set; }

        public string CustomerSignedId { get; set; }

        [StringLength(40)]
        public string CustomerSignedTitle { get; set; }

        public DateTimeOffset? CustomerSignedDate { get; set; }

        public string SpecialTerms { get; set; }

        public string ActivatedById { get; set; }

        public DateTimeOffset? ActivatedDate { get; set; }

        public string StatusCode { get; set; }

        public string Description { get; set; }

        public bool IsDeleted { get; set; }

        [StringLength(30)]
        public string ContractNumber { get; set; }

        public DateTimeOffset? LastApprovedDate { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        public DateTimeOffset? LastActivityDate { get; set; }

        public DateTimeOffset? LastViewedDate { get; set; }

        public DateTimeOffset? LastReferencedDate { get; set; }

    }
}
