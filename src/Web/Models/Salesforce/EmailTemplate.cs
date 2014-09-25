using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class EmailTemplate
    {
        [Key]
        public string Id { get; set; }

        [StringLength(80)]
        public string Name { get; set; }

        [StringLength(80)]
        public string DeveloperName { get; set; }

        [StringLength(15)]
        public string NamespacePrefix { get; set; }

        public string OwnerId { get; set; }

        public string FolderId { get; set; }

        public string BrandTemplateId { get; set; }

        public string TemplateStyle { get; set; }

        public bool IsActive { get; set; }

        public string TemplateType { get; set; }

        public string Encoding { get; set; }

        [StringLength(4000)]
        public string Description { get; set; }

        [StringLength(255)]
        public string Subject { get; set; }

        public string HtmlValue { get; set; }

        public string Body { get; set; }

        public int? TimesUsed { get; set; }

        public DateTimeOffset? LastUsedDate { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        public double? ApiVersion { get; set; }

        public string Markup { get; set; }

    }
}
