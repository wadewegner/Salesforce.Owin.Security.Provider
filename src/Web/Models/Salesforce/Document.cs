using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class Document
    {
        [Key]
        public string Id { get; set; }

        public string FolderId { get; set; }

        public bool IsDeleted { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(80)]
        public string DeveloperName { get; set; }

        [StringLength(15)]
        public string NamespacePrefix { get; set; }

        [StringLength(120)]
        public string ContentType { get; set; }

        [StringLength(40)]
        public string Type { get; set; }

        public bool IsPublic { get; set; }

        public int BodyLength { get; set; }

        public byte[] Body { get; set; }

        [StringLength(255)]
        public string Url { get; set; }

        public string Description { get; set; }

        [StringLength(255)]
        public string Keywords { get; set; }

        public bool IsInternalUseOnly { get; set; }

        public string AuthorId { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        public bool IsBodySearchable { get; set; }

        public DateTimeOffset? LastViewedDate { get; set; }

        public DateTimeOffset? LastReferencedDate { get; set; }

    }
}
