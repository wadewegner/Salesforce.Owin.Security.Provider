using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class TopicAssignment
    {
        [Key]
        public string Id { get; set; }

        public string TopicId { get; set; }

        public string EntityId { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public bool IsDeleted { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

    }
}
