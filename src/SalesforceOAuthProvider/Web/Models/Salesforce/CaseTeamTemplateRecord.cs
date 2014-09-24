﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class CaseTeamTemplateRecord
    {
        [Key]
        public string Id { get; set; }

        public string ParentId { get; set; }

        public string TeamTemplateId { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

    }
}
