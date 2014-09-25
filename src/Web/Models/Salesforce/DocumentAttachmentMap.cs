using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class DocumentAttachmentMap
    {
        [Key]
        public string Id { get; set; }

        public string ParentId { get; set; }

        public string DocumentId { get; set; }

        public int DocumentSequence { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

    }
}
