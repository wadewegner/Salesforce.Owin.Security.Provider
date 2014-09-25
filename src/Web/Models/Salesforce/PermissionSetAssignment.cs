using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class PermissionSetAssignment
    {
        [Key]
        public string Id { get; set; }

        public string PermissionSetId { get; set; }

        public string AssigneeId { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

    }
}
