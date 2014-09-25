using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class EmailServicesAddress
    {
        [Key]
        public string Id { get; set; }

        public bool IsActive { get; set; }

        [StringLength(64)]
        public string LocalPart { get; set; }

        [StringLength(255)]
        public string EmailDomainName { get; set; }

        public string AuthorizedSenders { get; set; }

        public string RunAsUserId { get; set; }

        public string FunctionId { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

    }
}
