using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class FeedLike
    {
        [Key]
        public string Id { get; set; }

        public string FeedItemId { get; set; }

        public string FeedEntityId { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public bool IsDeleted { get; set; }

        public string InsertedById { get; set; }

    }
}
