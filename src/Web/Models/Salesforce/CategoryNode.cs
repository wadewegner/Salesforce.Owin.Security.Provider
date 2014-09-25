using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class CategoryNode
    {
        [Key]
        public string Id { get; set; }

        public string ParentId { get; set; }

        [StringLength(40)]
        public string MasterLabel { get; set; }

        public int? SortOrder { get; set; }

        public string SortStyle { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

    }
}
