using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class LoginIp
    {
        [Key]
        public string Id { get; set; }

        public string UsersId { get; set; }

        [StringLength(39)]
        public string SourceIp { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public bool IsAuthenticated { get; set; }

        public DateTimeOffset? ChallengeSentDate { get; set; }

        public string ChallengeMethod { get; set; }

    }
}
