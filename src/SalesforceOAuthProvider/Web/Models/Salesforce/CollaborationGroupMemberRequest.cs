﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class CollaborationGroupMemberRequest
    {
        [Key]
        public string Id { get; set; }

        public string CollaborationGroupId { get; set; }

        public string RequesterId { get; set; }

        [StringLength(255)]
        public string ResponseMessage { get; set; }

        public string Status { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

    }
}
