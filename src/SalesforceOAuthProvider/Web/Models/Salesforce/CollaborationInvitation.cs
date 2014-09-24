using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class CollaborationInvitation
    {
        [Key]
        public string Id { get; set; }

        public string ParentId { get; set; }

        public string SharedEntityId { get; set; }

        public string InviterId { get; set; }

        [StringLength(240)]
        public string InvitedUserEmail { get; set; }

        [EmailAddress]
        public string InvitedUserEmailNormalized { get; set; }

        public string Status { get; set; }

        [StringLength(255)]
        public string OptionalMessage { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

    }
}
