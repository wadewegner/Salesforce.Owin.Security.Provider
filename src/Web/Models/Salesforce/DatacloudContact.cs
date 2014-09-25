using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class DatacloudContact
    {
        [Key]
        public string Id { get; set; }

        [StringLength(255)]
        public string ExternalId { get; set; }

        [StringLength(25)]
        public string CompanyId { get; set; }

        [StringLength(25)]
        public string ContactId { get; set; }

        [StringLength(128)]
        public string CompanyName { get; set; }

        [StringLength(128)]
        public string Title { get; set; }

        public bool IsInactive { get; set; }

        [StringLength(128)]
        public string FirstName { get; set; }

        [StringLength(128)]
        public string LastName { get; set; }

        [Phone]
        public string Phone { get; set; }

        [EmailAddress]
        public string Email { get; set; }

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
        public string Department { get; set; }

        [StringLength(128)]
        public string Level { get; set; }

        public bool IsOwned { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }

    }
}
