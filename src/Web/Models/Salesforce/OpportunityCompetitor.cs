using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class OpportunityCompetitor
    {
        [Key]
        public string Id { get; set; }

        public string OpportunityId { get; set; }

        public string CompetitorName { get; set; }

        [StringLength(1000)]
        public string Strengths { get; set; }

        [StringLength(1000)]
        public string Weaknesses { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        public bool IsDeleted { get; set; }

    }
}
