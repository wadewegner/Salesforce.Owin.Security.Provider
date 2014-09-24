using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class CallCenter
    {
        [Key]
        public string Id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(240)]
        public string InternalName { get; set; }

        public double? Version { get; set; }

        [StringLength(2000)]
        public string AdapterUrl { get; set; }

        [StringLength(3000)]
        public string CustomSettings { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

    }
}
