using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class DeclinedEventRelation
    {
        [Key]
        public string Id { get; set; }

        public string RelationId { get; set; }

        public string EventId { get; set; }

        public DateTimeOffset? RespondedDate { get; set; }

        [StringLength(255)]
        public string Response { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        public bool IsDeleted { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

    }
}
