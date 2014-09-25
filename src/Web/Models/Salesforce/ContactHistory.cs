﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class ContactHistory
    {
        [Key]
        public string Id { get; set; }

        public bool IsDeleted { get; set; }

        public string ContactId { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string Field { get; set; }

        public object OldValue { get; set; }

        public object NewValue { get; set; }

    }
}