using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class Dashboard
    {
        [Key]
        public string Id { get; set; }

        public bool IsDeleted { get; set; }

        public string FolderId { get; set; }

        [StringLength(80)]
        public string Title { get; set; }

        [StringLength(80)]
        public string DeveloperName { get; set; }

        [StringLength(15)]
        public string NamespacePrefix { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public string LeftSize { get; set; }

        public string MiddleSize { get; set; }

        public string RightSize { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        public string RunningUserId { get; set; }

        public int TitleColor { get; set; }

        public int TitleSize { get; set; }

        public int TextColor { get; set; }

        public int BackgroundStart { get; set; }

        public int BackgroundEnd { get; set; }

        public string BackgroundDirection { get; set; }

        public string Type { get; set; }

        public DateTimeOffset? LastViewedDate { get; set; }

        public DateTimeOffset? LastReferencedDate { get; set; }

    }
}
