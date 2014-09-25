using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class ContentVersion
    {
        [Key]
        public string Id { get; set; }

        public string ContentDocumentId { get; set; }

        public bool IsLatest { get; set; }

        [Url]
        public string ContentUrl { get; set; }

        [StringLength(20)]
        public string VersionNumber { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        public string Description { get; set; }

        [StringLength(1000)]
        public string ReasonForChange { get; set; }

        [StringLength(500)]
        public string PathOnClient { get; set; }

        public int? RatingCount { get; set; }

        public bool IsDeleted { get; set; }

        public DateTimeOffset? ContentModifiedDate { get; set; }

        public string ContentModifiedById { get; set; }

        public int? PositiveRatingCount { get; set; }

        public int? NegativeRatingCount { get; set; }

        public int? FeaturedContentBoost { get; set; }

        public DateTimeOffset? FeaturedContentDate { get; set; }

        public string OwnerId { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        public string TagCsv { get; set; }

        [StringLength(20)]
        public string FileType { get; set; }

        public string PublishStatus { get; set; }

        public byte[] VersionData { get; set; }

        public int? ContentSize { get; set; }

        public string FirstPublishLocationId { get; set; }

        public string Origin { get; set; }

        [StringLength(50)]
        public string Checksum { get; set; }

    }
}
