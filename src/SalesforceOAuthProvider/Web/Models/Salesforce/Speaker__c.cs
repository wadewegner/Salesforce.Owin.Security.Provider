﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class Speaker__c
    {
        [Key]
        public string Id { get; set; }

        public string OwnerId { get; set; }

        public bool IsDeleted { get; set; }

        [StringLength(80)]
        public string Name { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        public DateTimeOffset? LastViewedDate { get; set; }

        public DateTimeOffset? LastReferencedDate { get; set; }

        [StringLength(30)]
        public string First_Name__c { get; set; }

        [StringLength(30)]
        public string Last_Name__c { get; set; }

        [EmailAddress]
        public string Email__c { get; set; }

        public string Bio__c { get; set; }

    }
}
