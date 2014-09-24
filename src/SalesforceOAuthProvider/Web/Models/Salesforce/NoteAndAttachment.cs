using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class NoteAndAttachment
    {
        [Key]
        public string Id { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsNote { get; set; }

        public string ParentId { get; set; }

        [StringLength(80)]
        public string Title { get; set; }

        public bool IsPrivate { get; set; }

        public string OwnerId { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

    }
}
