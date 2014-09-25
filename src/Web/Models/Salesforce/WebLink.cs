using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class WebLink
    {
        [Key]
        public string Id { get; set; }

        public string PageOrSobjectType { get; set; }

        [StringLength(240)]
        public string Name { get; set; }

        public bool IsProtected { get; set; }

        public string Url { get; set; }

        public string EncodingKey { get; set; }

        public string LinkType { get; set; }

        public string OpenType { get; set; }

        public int? Height { get; set; }

        public int? Width { get; set; }

        public bool ShowsLocation { get; set; }

        public bool HasScrollbars { get; set; }

        public bool HasToolbar { get; set; }

        public bool HasMenubar { get; set; }

        public bool ShowsStatus { get; set; }

        public bool IsResizable { get; set; }

        public string Position { get; set; }

        public string ScontrolId { get; set; }

        [StringLength(240)]
        public string MasterLabel { get; set; }

        public string Description { get; set; }

        public string DisplayType { get; set; }

        public bool RequireRowSelection { get; set; }

        [StringLength(15)]
        public string NamespacePrefix { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

    }
}
