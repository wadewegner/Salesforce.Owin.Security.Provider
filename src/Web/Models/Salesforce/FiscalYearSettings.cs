using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class FiscalYearSettings
    {
        [Key]
        public string Id { get; set; }

        public string PeriodId { get; set; }

        public DateTimeOffset? StartDate { get; set; }

        public DateTimeOffset? EndDate { get; set; }

        [StringLength(80)]
        public string Name { get; set; }

        public bool IsStandardYear { get; set; }

        public string YearType { get; set; }

        public string QuarterLabelScheme { get; set; }

        public string PeriodLabelScheme { get; set; }

        public string WeekLabelScheme { get; set; }

        public string QuarterPrefix { get; set; }

        public string PeriodPrefix { get; set; }

        public int? WeekStartDay { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

    }
}
