using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class ContentDocument
    {
        [Key]
        public string Id { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public bool IsArchived { get; set; }

        public string ArchivedById { get; set; }

        public DateTimeOffset? ArchivedDate { get; set; }

        public bool IsDeleted { get; set; }

        public string OwnerId { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        public string PublishStatus { get; set; }

        public string LatestPublishedVersionId { get; set; }

        public string ParentId { get; set; }

        public DateTimeOffset? LastViewedDate { get; set; }

        public DateTimeOffset? LastReferencedDate { get; set; }

    }
}
