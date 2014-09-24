using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class SetupEntityAccess
    {
        [Key]
        public string Id { get; set; }

        public string ParentId { get; set; }

        public string SetupEntityId { get; set; }

        public string SetupEntityType { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

    }
}
