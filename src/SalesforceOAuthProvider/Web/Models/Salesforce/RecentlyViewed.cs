using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class RecentlyViewed
    {
        [Key]
        public string Id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(80)]
        public string LastName { get; set; }

        [StringLength(40)]
        public string FirstName { get; set; }

        public string Type { get; set; }

        [StringLength(8)]
        public string Alias { get; set; }

        public string UserRoleId { get; set; }

        public string RecordTypeId { get; set; }

        public bool IsActive { get; set; }

        public string ProfileId { get; set; }

        [StringLength(80)]
        public string Title { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Phone { get; set; }

        public DateTimeOffset? LastViewedDate { get; set; }

        public DateTimeOffset? LastReferencedDate { get; set; }

        public string Language { get; set; }

    }
}
