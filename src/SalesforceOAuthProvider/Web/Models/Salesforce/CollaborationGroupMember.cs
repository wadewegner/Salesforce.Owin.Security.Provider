using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class CollaborationGroupMember
    {
        [Key]
        public string Id { get; set; }

        public string CollaborationGroupId { get; set; }

        public string MemberId { get; set; }

        public string CollaborationRole { get; set; }

        public string NotificationFrequency { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

    }
}
