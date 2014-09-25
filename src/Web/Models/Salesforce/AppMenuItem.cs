using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class AppMenuItem
    {
        [Key]
        public string Id { get; set; }

        public bool IsDeleted { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        public int SortOrder { get; set; }

        [StringLength(80)]
        public string Name { get; set; }

        [StringLength(80)]
        public string NamespacePrefix { get; set; }

        [StringLength(250)]
        public string Label { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        [Url]
        public string StartUrl { get; set; }

        [Url]
        public string MobileStartUrl { get; set; }

        [Url]
        public string LogoUrl { get; set; }

        [Url]
        public string IconUrl { get; set; }

        [Url]
        public string InfoUrl { get; set; }

        public bool IsUsingAdminAuthorization { get; set; }

        public string MobilePlatform { get; set; }

        [StringLength(255)]
        public string MobileMinOsVer { get; set; }

        [StringLength(255)]
        public string MobileDeviceType { get; set; }

        public bool IsRegisteredDeviceOnly { get; set; }

        [StringLength(255)]
        public string MobileAppVer { get; set; }

        public DateTimeOffset? MobileAppInstalledDate { get; set; }

        [StringLength(255)]
        public string MobileAppInstalledVersion { get; set; }

        [StringLength(255)]
        public string MobileAppBinaryId { get; set; }

        [Url]
        public string MobileAppInstallUrl { get; set; }

        public bool CanvasEnabled { get; set; }

        [StringLength(18)]
        public string CanvasReferenceId { get; set; }

        [Url]
        public string CanvasUrl { get; set; }

        public string CanvasAccessMethod { get; set; }

        [StringLength(255)]
        public string CanvasSelectedLocations { get; set; }

        public string Type { get; set; }

    }
}
