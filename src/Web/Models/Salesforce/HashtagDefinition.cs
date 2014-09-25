using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class HashtagDefinition
    {
        [Key]
        public string Id { get; set; }

        [StringLength(765)]
        public string NameNorm { get; set; }

        [StringLength(765)]
        public string Name { get; set; }

        public int? HashtagCount { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

    }
}
