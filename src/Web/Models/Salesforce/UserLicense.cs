using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class UserLicense
    {
        [Key]
        public string Id { get; set; }

        [StringLength(40)]
        public string LicenseDefinitionKey { get; set; }

        [StringLength(40)]
        public string Name { get; set; }

        public int? MonthlyLoginsUsed { get; set; }

        public int? MonthlyLoginsEntitlement { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

    }
}
