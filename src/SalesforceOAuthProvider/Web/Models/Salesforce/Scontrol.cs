using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class Scontrol
    {
        [Key]
        public string Id { get; set; }

        [StringLength(80)]
        public string Name { get; set; }

        [StringLength(80)]
        public string DeveloperName { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public string EncodingKey { get; set; }

        public string HtmlWrapper { get; set; }

        [StringLength(255)]
        public string Filename { get; set; }

        public int BodyLength { get; set; }

        public byte[] Binary { get; set; }

        public string ContentSource { get; set; }

        public bool SupportsCaching { get; set; }

        [StringLength(15)]
        public string NamespacePrefix { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

    }
}
