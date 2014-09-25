using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class ApexPage
    {
        [Key]
        public string Id { get; set; }

        [StringLength(15)]
        public string NamespacePrefix { get; set; }

        [StringLength(80)]
        public string Name { get; set; }

        public double ApiVersion { get; set; }

        [StringLength(80)]
        public string MasterLabel { get; set; }

        public string Description { get; set; }

        public string ControllerType { get; set; }

        [StringLength(255)]
        public string ControllerKey { get; set; }

        public bool IsAvailableInTouch { get; set; }

        public bool IsConfirmationTokenRequired { get; set; }

        public string Markup { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

    }
}
