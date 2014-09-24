using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class CampaignMember
    {
        [Key]
        public string Id { get; set; }

        public bool IsDeleted { get; set; }

        public string CampaignId { get; set; }

        public string LeadId { get; set; }

        public string ContactId { get; set; }

        public string Status { get; set; }

        public bool HasResponded { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        public DateTimeOffset? FirstRespondedDate { get; set; }

    }
}
