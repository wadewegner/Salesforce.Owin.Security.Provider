using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class IdeaComment
    {
        [Key]
        public string Id { get; set; }

        public string IdeaId { get; set; }

        public string CommunityId { get; set; }

        public string CommentBody { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsHtml { get; set; }

        [StringLength(255)]
        public string CreatorFullPhotoUrl { get; set; }

        [StringLength(255)]
        public string CreatorSmallPhotoUrl { get; set; }

        [StringLength(121)]
        public string CreatorName { get; set; }

        public int? UpVotes { get; set; }

    }
}
