using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class EmailStatus
    {
        [Key]
        public string Id { get; set; }

        public string TaskId { get; set; }

        public string WhoId { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public int TimesOpened { get; set; }

        public DateTimeOffset? FirstOpenDate { get; set; }

        public DateTimeOffset? LastOpenDate { get; set; }

        [StringLength(80)]
        public string EmailTemplateName { get; set; }

    }
}
