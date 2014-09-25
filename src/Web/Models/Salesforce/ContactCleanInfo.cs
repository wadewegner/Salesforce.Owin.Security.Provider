using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class ContactCleanInfo
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

        public string ContactId { get; set; }

        public DateTimeOffset LastMatchedDate { get; set; }

        public DateTimeOffset? LastStatusChangedDate { get; set; }

        public string LastStatusChangedById { get; set; }

        public bool IsInactive { get; set; }

        [StringLength(255)]
        public string FirstName { get; set; }

        [StringLength(255)]
        public string LastName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

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

        [StringLength(128)]
        public string Title { get; set; }

        public string ContactStatusDataDotCom { get; set; }

        public bool IsReviewedName { get; set; }

        public bool IsReviewedEmail { get; set; }

        public bool IsReviewedPhone { get; set; }

        public bool IsReviewedAddress { get; set; }

        public bool IsReviewedTitle { get; set; }

        public bool IsDifferentFirstName { get; set; }

        public bool IsDifferentLastName { get; set; }

        public bool IsDifferentEmail { get; set; }

        public bool IsDifferentPhone { get; set; }

        public bool IsDifferentStreet { get; set; }

        public bool IsDifferentCity { get; set; }

        public bool IsDifferentState { get; set; }

        public bool IsDifferentPostalCode { get; set; }

        public bool IsDifferentCountry { get; set; }

        public bool IsDifferentTitle { get; set; }

        public bool IsDifferentStateCode { get; set; }

        public bool IsDifferentCountryCode { get; set; }

        public bool CleanedByJob { get; set; }

        public bool CleanedByUser { get; set; }

        public bool IsFlaggedWrongName { get; set; }

        public bool IsFlaggedWrongEmail { get; set; }

        public bool IsFlaggedWrongPhone { get; set; }

        public bool IsFlaggedWrongAddress { get; set; }

        public bool IsFlaggedWrongTitle { get; set; }

        [StringLength(20)]
        public string DataDotComId { get; set; }

    }
}
