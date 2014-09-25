using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class UserRecordAccess
    {
        [Key]
        public string Id { get; set; }

        public string UserId { get; set; }

        public string RecordId { get; set; }

        public bool HasReadAccess { get; set; }

        public bool HasEditAccess { get; set; }

        public bool HasDeleteAccess { get; set; }

        public bool HasTransferAccess { get; set; }

        public bool HasAllAccess { get; set; }

        public string MaxAccessLevel { get; set; }

    }
}
