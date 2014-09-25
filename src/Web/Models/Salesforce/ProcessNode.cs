using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class ProcessNode
    {
        [Key]
        public string Id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(80)]
        public string DeveloperName { get; set; }

        public string ProcessDefinitionId { get; set; }

        public string Description { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

    }
}
