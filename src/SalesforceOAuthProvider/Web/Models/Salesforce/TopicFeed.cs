using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class TopicFeed
    {
        [Key]
        public string Id { get; set; }

        public string ParentId { get; set; }

        public string Type { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public bool IsDeleted { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        public int CommentCount { get; set; }

        public int LikeCount { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        public string Body { get; set; }

        [Url]
        public string LinkUrl { get; set; }

        public string RelatedRecordId { get; set; }

        public byte[] ContentData { get; set; }

        [StringLength(255)]
        public string ContentFileName { get; set; }

        public string ContentDescription { get; set; }

        [StringLength(120)]
        public string ContentType { get; set; }

        public int? ContentSize { get; set; }

        public string InsertedById { get; set; }

    }
}
