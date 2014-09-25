using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class ObjectPermissions
    {
        [Key]
        public string Id { get; set; }

        public string ParentId { get; set; }

        public string SobjectType { get; set; }

        public bool PermissionsCreate { get; set; }

        public bool PermissionsRead { get; set; }

        public bool PermissionsEdit { get; set; }

        public bool PermissionsDelete { get; set; }

        public bool PermissionsViewAllRecords { get; set; }

        public bool PermissionsModifyAllRecords { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

    }
}
