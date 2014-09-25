using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class Solution
    {
        [Key]
        public string Id { get; set; }

        public bool IsDeleted { get; set; }

        [StringLength(30)]
        public string SolutionNumber { get; set; }

        [StringLength(255)]
        public string SolutionName { get; set; }

        public bool IsPublished { get; set; }

        public bool IsPublishedInPublicKb { get; set; }

        public string Status { get; set; }

        public bool IsReviewed { get; set; }

        public string SolutionNote { get; set; }

        public string OwnerId { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        public int TimesUsed { get; set; }

        public DateTimeOffset? LastViewedDate { get; set; }

        public DateTimeOffset? LastReferencedDate { get; set; }

        public bool IsHtml { get; set; }

    }
}
