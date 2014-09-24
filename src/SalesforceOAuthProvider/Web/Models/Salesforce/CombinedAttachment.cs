using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class CombinedAttachment
    {
        [Key]
        public string Id { get; set; }

        public bool IsDeleted { get; set; }

        public string ParentId { get; set; }

        [StringLength(30)]
        public string RecordType { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        [StringLength(30)]
        public string FileType { get; set; }

        public int? ContentSize { get; set; }

    }
}
