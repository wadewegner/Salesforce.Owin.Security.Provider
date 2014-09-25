using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class ContentWorkspaceDoc
    {
        [Key]
        public string Id { get; set; }

        public string ContentWorkspaceId { get; set; }

        public string ContentDocumentId { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        public bool IsOwner { get; set; }

        public bool IsDeleted { get; set; }

    }
}
