using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class FeedComment
    {
        [Key]
        public string Id { get; set; }

        public string FeedItemId { get; set; }

        public string ParentId { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CommentBody { get; set; }

        public bool IsDeleted { get; set; }

        public string InsertedById { get; set; }

        public string CommentType { get; set; }

        public string RelatedRecordId { get; set; }

    }
}
