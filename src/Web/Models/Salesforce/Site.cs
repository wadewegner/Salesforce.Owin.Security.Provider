using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class Site
    {
        [Key]
        public string Id { get; set; }

        [StringLength(80)]
        public string Name { get; set; }

        [StringLength(80)]
        public string Subdomain { get; set; }

        [StringLength(40)]
        public string UrlPathPrefix { get; set; }

        public string GuestUserId { get; set; }

        public string Status { get; set; }

        public string AdminId { get; set; }

        public bool OptionsEnableFeeds { get; set; }

        public bool OptionsAllowHomePage { get; set; }

        public bool OptionsAllowStandardIdeasPages { get; set; }

        public bool OptionsAllowStandardSearch { get; set; }

        public bool OptionsAllowStandardLookups { get; set; }

        public bool OptionsAllowStandardAnswersPages { get; set; }

        public string Description { get; set; }

        [StringLength(255)]
        public string MasterLabel { get; set; }

        [StringLength(40)]
        public string AnalyticsTrackingCode { get; set; }

        public string SiteType { get; set; }

        public string ClickjackProtectionLevel { get; set; }

        public int? DailyBandwidthLimit { get; set; }

        public int? DailyBandwidthUsed { get; set; }

        public int? DailyRequestTimeLimit { get; set; }

        public int? DailyRequestTimeUsed { get; set; }

        public int? MonthlyPageViewsEntitlement { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

    }
}
