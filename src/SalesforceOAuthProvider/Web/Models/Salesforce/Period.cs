using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class Period
    {
        [Key]
        public string Id { get; set; }

        public string FiscalYearSettingsId { get; set; }

        public string Type { get; set; }

        public DateTimeOffset StartDate { get; set; }

        public DateTimeOffset EndDate { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        public bool IsForecastPeriod { get; set; }

        public string QuarterLabel { get; set; }

        public string PeriodLabel { get; set; }

        public int? Number { get; set; }

    }
}
