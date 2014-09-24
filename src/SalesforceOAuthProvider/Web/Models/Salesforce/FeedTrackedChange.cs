using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class FeedTrackedChange
    {
        [Key]
        public string Id { get; set; }

        public string FeedItemId { get; set; }

        [StringLength(120)]
        public string FieldName { get; set; }

        public object OldValue { get; set; }

        public object NewValue { get; set; }

    }
}
