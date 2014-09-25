using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class AuthSession
    {
        [Key]
        public string Id { get; set; }

        public string UsersId { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public int NumSecondsValid { get; set; }

        public string UserType { get; set; }

        [StringLength(39)]
        public string SourceIp { get; set; }

        public string LoginType { get; set; }

        public string SessionType { get; set; }

        public string SessionSecurityLevel { get; set; }

    }
}
