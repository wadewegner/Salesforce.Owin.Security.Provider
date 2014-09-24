using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class UserShare
    {
        [Key]
        public string Id { get; set; }

        public string UserId { get; set; }

        public string UserOrGroupId { get; set; }

        public string UserAccessLevel { get; set; }

        public string RowCause { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public bool IsActive { get; set; }

    }
}
