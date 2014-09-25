using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class UserPreference
    {
        [Key]
        public string Id { get; set; }

        public string UserId { get; set; }

        public string Preference { get; set; }

        [StringLength(1333)]
        public string Value { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

    }
}
