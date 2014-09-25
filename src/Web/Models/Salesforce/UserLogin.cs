using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class UserLogin
    {
        [Key]
        public string Id { get; set; }

        public string UserId { get; set; }

        public bool IsFrozen { get; set; }

        public bool IsPasswordLocked { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

    }
}
