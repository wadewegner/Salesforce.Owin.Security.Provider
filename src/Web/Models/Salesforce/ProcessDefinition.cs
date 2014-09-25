using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class ProcessDefinition
    {
        [Key]
        public string Id { get; set; }

        [StringLength(40)]
        public string Name { get; set; }

        [StringLength(80)]
        public string DeveloperName { get; set; }

        public string Type { get; set; }

        public string Description { get; set; }

        public string TableEnumOrId { get; set; }

        public string LockType { get; set; }

        public string State { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

    }
}
