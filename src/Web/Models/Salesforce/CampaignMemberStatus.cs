using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class CampaignMemberStatus
    {
        [Key]
        public string Id { get; set; }

        public bool IsDeleted { get; set; }

        public string CampaignId { get; set; }

        [StringLength(765)]
        public string Label { get; set; }

        public int SortOrder { get; set; }

        public bool IsDefault { get; set; }

        public bool HasResponded { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

    }
}
