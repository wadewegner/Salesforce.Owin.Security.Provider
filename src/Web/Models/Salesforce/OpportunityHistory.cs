using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class OpportunityHistory
    {
        [Key]
        public string Id { get; set; }

        public string OpportunityId { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string StageName { get; set; }

        public double? Amount { get; set; }

        public double? ExpectedRevenue { get; set; }

        public DateTimeOffset? CloseDate { get; set; }

        public double? Probability { get; set; }

        public string ForecastCategory { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        public bool IsDeleted { get; set; }

    }
}
