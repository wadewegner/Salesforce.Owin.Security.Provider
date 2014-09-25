using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class CollaborationGroup
    {
        [Key]
        public string Id { get; set; }

        [StringLength(40)]
        public string Name { get; set; }

        public int? MemberCount { get; set; }

        public string OwnerId { get; set; }

        public string CollaborationType { get; set; }

        public string Description { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        [Url]
        public string FullPhotoUrl { get; set; }

        [Url]
        public string SmallPhotoUrl { get; set; }

        public DateTimeOffset LastFeedModifiedDate { get; set; }

        [StringLength(30)]
        public string InformationTitle { get; set; }

        public string InformationBody { get; set; }

        public bool HasPrivateFieldsAccess { get; set; }

        public bool CanHaveGuests { get; set; }

        public DateTimeOffset? LastViewedDate { get; set; }

        public DateTimeOffset? LastReferencedDate { get; set; }

        public bool IsArchived { get; set; }

        public bool IsAutoArchiveDisabled { get; set; }

        public string AnnouncementId { get; set; }

    }
}
