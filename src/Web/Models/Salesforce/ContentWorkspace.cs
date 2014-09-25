using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class ContentWorkspace
    {
        [Key]
        public string Id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public string Description { get; set; }

        public string TagModel { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string DefaultRecordTypeId { get; set; }

        public bool IsRestrictContentTypes { get; set; }

        public bool IsRestrictLinkedContentTypes { get; set; }

    }
}
