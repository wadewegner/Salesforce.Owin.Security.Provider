using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class Group
    {
        [Key]
        public string Id { get; set; }

        [StringLength(40)]
        public string Name { get; set; }

        [StringLength(80)]
        public string DeveloperName { get; set; }

        public string RelatedId { get; set; }

        public string Type { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string OwnerId { get; set; }

        public bool DoesSendEmailToMembers { get; set; }

        public bool DoesIncludeBosses { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

    }
}
