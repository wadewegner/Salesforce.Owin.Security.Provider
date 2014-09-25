using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class Topic
    {
        [Key]
        public string Id { get; set; }

        [StringLength(99)]
        public string Name { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public int TalkingAbout { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

    }
}
