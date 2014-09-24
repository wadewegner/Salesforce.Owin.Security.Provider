using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class AdditionalNumber
    {
        [Key]
        public string Id { get; set; }

        public bool IsDeleted { get; set; }

        public string CallCenterId { get; set; }

        [StringLength(80)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Phone]
        public string Phone { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

    }
}
