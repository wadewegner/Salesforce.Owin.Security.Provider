using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class UserRole
    {
        [Key]
        public string Id { get; set; }

        [StringLength(80)]
        public string Name { get; set; }

        public string ParentRoleId { get; set; }

        [StringLength(80)]
        public string RollupDescription { get; set; }

        public string OpportunityAccessForAccountOwner { get; set; }

        public string CaseAccessForAccountOwner { get; set; }

        public string ContactAccessForAccountOwner { get; set; }

        public string ForecastUserId { get; set; }

        public bool MayForecastManagerShare { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        [StringLength(80)]
        public string DeveloperName { get; set; }

        public string PortalAccountId { get; set; }

        public string PortalType { get; set; }

        public string PortalAccountOwnerId { get; set; }

    }
}
