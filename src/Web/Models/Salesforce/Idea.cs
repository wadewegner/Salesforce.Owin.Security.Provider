using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class Idea
    {
        [Key]
        public string Id { get; set; }

        public bool IsDeleted { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        public string RecordTypeId { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        public DateTimeOffset? LastViewedDate { get; set; }

        public DateTimeOffset? LastReferencedDate { get; set; }

        public string CommunityId { get; set; }

        public string Body { get; set; }

        public int? NumComments { get; set; }

        public double? VoteScore { get; set; }

        public double? VoteTotal { get; set; }

        public string Categories { get; set; }

        public string Status { get; set; }

        public DateTimeOffset? LastCommentDate { get; set; }

        public string LastCommentId { get; set; }

        public string ParentIdeaId { get; set; }

        public bool IsHtml { get; set; }

        public bool IsMerged { get; set; }

        [StringLength(255)]
        public string CreatorFullPhotoUrl { get; set; }

        [StringLength(255)]
        public string CreatorSmallPhotoUrl { get; set; }

        [StringLength(121)]
        public string CreatorName { get; set; }

    }
}
