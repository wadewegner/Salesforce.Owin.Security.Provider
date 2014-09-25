using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class CaseSolution
    {
        [Key]
        public string Id { get; set; }

        public string CaseId { get; set; }

        public string SolutionId { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        public bool IsDeleted { get; set; }

    }
}
