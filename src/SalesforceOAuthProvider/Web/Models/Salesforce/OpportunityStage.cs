using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class OpportunityStage
    {
        [Key]
        public string Id { get; set; }

        [StringLength(255)]
        public string MasterLabel { get; set; }

        public bool IsActive { get; set; }

        public int? SortOrder { get; set; }

        public bool IsClosed { get; set; }

        public bool IsWon { get; set; }

        public string ForecastCategory { get; set; }

        public string ForecastCategoryName { get; set; }

        public double? DefaultProbability { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

    }
}
