using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class CronJobDetail
    {
        [Key]
        public string Id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public string JobType { get; set; }

    }
}
