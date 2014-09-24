﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class OrgWideEmailAddress
    {
        [Key]
        public string Id { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        [EmailAddress]
        public string Address { get; set; }

        [StringLength(300)]
        public string DisplayName { get; set; }

        public bool IsAllowAllProfiles { get; set; }

    }
}
