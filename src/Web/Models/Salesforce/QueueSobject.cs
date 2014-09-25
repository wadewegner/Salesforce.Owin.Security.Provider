using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class QueueSobject
    {
        [Key]
        public string Id { get; set; }

        public string QueueId { get; set; }

        public string SobjectType { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

    }
}
