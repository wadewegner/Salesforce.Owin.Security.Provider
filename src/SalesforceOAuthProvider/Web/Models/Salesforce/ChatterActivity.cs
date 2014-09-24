using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class ChatterActivity
    {
        [Key]
        public string Id { get; set; }

        public string ParentId { get; set; }

        public int PostCount { get; set; }

        public int CommentCount { get; set; }

        public int CommentReceivedCount { get; set; }

        public int LikeReceivedCount { get; set; }

        public int InfluenceRawRank { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

    }
}
