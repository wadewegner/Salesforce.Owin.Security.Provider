using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class PushTopic
    {
        [Key]
        public string Id { get; set; }

        [StringLength(25)]
        public string Name { get; set; }

        [StringLength(1300)]
        public string Query { get; set; }

        public double ApiVersion { get; set; }

        public bool IsActive { get; set; }

        public string NotifyForFields { get; set; }

        public string NotifyForOperations { get; set; }

        [StringLength(400)]
        public string Description { get; set; }

        public bool NotifyForOperationCreate { get; set; }

        public bool NotifyForOperationUpdate { get; set; }

        public bool NotifyForOperationDelete { get; set; }

        public bool NotifyForOperationUndelete { get; set; }

        public bool IsDeleted { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

    }
}
