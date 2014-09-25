using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class Order
    {
        [Key]
        public string Id { get; set; }

        public string ContractId { get; set; }

        public string AccountId { get; set; }

        public string Pricebook2Id { get; set; }

        public string OriginalOrderId { get; set; }

        public DateTimeOffset EffectiveDate { get; set; }

        public DateTimeOffset? EndDate { get; set; }

        public bool IsReductionOrder { get; set; }

        public string Status { get; set; }

        public string Description { get; set; }

        public string CustomerAuthorizedById { get; set; }

        public DateTimeOffset? CustomerAuthorizedDate { get; set; }

        public string CompanyAuthorizedById { get; set; }

        public DateTimeOffset? CompanyAuthorizedDate { get; set; }

        public string Type { get; set; }

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

        [StringLength(80)]
        public string Name { get; set; }

        public DateTimeOffset? PoDate { get; set; }

        [StringLength(80)]
        public string PoNumber { get; set; }

        [StringLength(80)]
        public string OrderReferenceNumber { get; set; }

        public string BillToContactId { get; set; }

        public string ShipToContactId { get; set; }

        public DateTimeOffset? ActivatedDate { get; set; }

        public string ActivatedById { get; set; }

        public string StatusCode { get; set; }

        [StringLength(30)]
        public string OrderNumber { get; set; }

        public double TotalAmount { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public bool IsDeleted { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        public DateTimeOffset? LastViewedDate { get; set; }

        public DateTimeOffset? LastReferencedDate { get; set; }

    }
}
