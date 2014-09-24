using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class ContentDocumentLink
    {
        [Key]
        public string Id { get; set; }

        public string LinkedEntityId { get; set; }

        public string ContentDocumentId { get; set; }

        public bool IsDeleted { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        public string ShareType { get; set; }

    }
}
