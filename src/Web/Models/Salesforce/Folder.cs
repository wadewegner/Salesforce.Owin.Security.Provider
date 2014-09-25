using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class Folder
    {
        [Key]
        public string Id { get; set; }

        [StringLength(40)]
        public string Name { get; set; }

        [StringLength(80)]
        public string DeveloperName { get; set; }

        public string AccessType { get; set; }

        public bool IsReadonly { get; set; }

        public string Type { get; set; }

        [StringLength(15)]
        public string NamespacePrefix { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

    }
}
