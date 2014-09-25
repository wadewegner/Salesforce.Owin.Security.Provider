using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class StaticResource
    {
        [Key]
        public string Id { get; set; }

        [StringLength(15)]
        public string NamespacePrefix { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(120)]
        public string ContentType { get; set; }

        public int BodyLength { get; set; }

        public byte[] Body { get; set; }

        public string Description { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        public string CacheControl { get; set; }

    }
}
