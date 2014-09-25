using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class FieldPermissions
    {
        [Key]
        public string Id { get; set; }

        public string ParentId { get; set; }

        public string SobjectType { get; set; }

        public string Field { get; set; }

        public bool PermissionsEdit { get; set; }

        public bool PermissionsRead { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

    }
}
