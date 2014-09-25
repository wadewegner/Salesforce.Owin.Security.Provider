using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class UserProfile
    {
        [Key]
        public string Id { get; set; }

        [StringLength(80)]
        public string LastName { get; set; }

        [StringLength(40)]
        public string FirstName { get; set; }

        [StringLength(121)]
        public string Name { get; set; }

        [StringLength(80)]
        public string Title { get; set; }

        public string ManagerId { get; set; }

        [StringLength(80)]
        public string CompanyName { get; set; }

        public string AboutMe { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Phone { get; set; }

        [Phone]
        public string MobilePhone { get; set; }

        [Phone]
        public string Fax { get; set; }

        public string Street { get; set; }

        [StringLength(40)]
        public string City { get; set; }

        [StringLength(80)]
        public string State { get; set; }

        [StringLength(20)]
        public string PostalCode { get; set; }

        [StringLength(80)]
        public string Country { get; set; }

        public double? Latitude { get; set; }

        public double? Longitude { get; set; }

        public bool IsBadged { get; set; }

        public bool IsActive { get; set; }

        public bool UserPreferencesActivityRemindersPopup { get; set; }

        public bool UserPreferencesEventRemindersCheckboxDefault { get; set; }

        public bool UserPreferencesTaskRemindersCheckboxDefault { get; set; }

        public bool UserPreferencesReminderSoundOff { get; set; }

        public bool UserPreferencesDisableAllFeedsEmail { get; set; }

        public bool UserPreferencesDisableFollowersEmail { get; set; }

        public bool UserPreferencesDisableProfilePostEmail { get; set; }

        public bool UserPreferencesDisableChangeCommentEmail { get; set; }

        public bool UserPreferencesDisableLaterCommentEmail { get; set; }

        public bool UserPreferencesDisProfPostCommentEmail { get; set; }

        public bool UserPreferencesContentNoEmail { get; set; }

        public bool UserPreferencesContentEmailAsAndWhen { get; set; }

        public bool UserPreferencesApexPagesDeveloperMode { get; set; }

        public bool UserPreferencesHideCSNGetChatterMobileTask { get; set; }

        public bool UserPreferencesDisableMentionsPostEmail { get; set; }

        public bool UserPreferencesDisMentionsCommentEmail { get; set; }

        public bool UserPreferencesHideCSNDesktopTask { get; set; }

        public bool UserPreferencesHideChatterOnboardingSplash { get; set; }

        public bool UserPreferencesHideSecondChatterOnboardingSplash { get; set; }

        public bool UserPreferencesDisCommentAfterLikeEmail { get; set; }

        public bool UserPreferencesDisableLikeEmail { get; set; }

        public bool UserPreferencesDisableMessageEmail { get; set; }

        public bool UserPreferencesJigsawListUser { get; set; }

        public bool UserPreferencesDisableBookmarkEmail { get; set; }

        public bool UserPreferencesDisableSharePostEmail { get; set; }

        public bool UserPreferencesEnableAutoSubForFeeds { get; set; }

        public bool UserPreferencesDisableFileShareNotificationsForApi { get; set; }

        public bool UserPreferencesShowTitleToExternalUsers { get; set; }

        public bool UserPreferencesShowManagerToExternalUsers { get; set; }

        public bool UserPreferencesShowEmailToExternalUsers { get; set; }

        public bool UserPreferencesShowWorkPhoneToExternalUsers { get; set; }

        public bool UserPreferencesShowMobilePhoneToExternalUsers { get; set; }

        public bool UserPreferencesShowFaxToExternalUsers { get; set; }

        public bool UserPreferencesShowStreetAddressToExternalUsers { get; set; }

        public bool UserPreferencesShowCityToExternalUsers { get; set; }

        public bool UserPreferencesShowStateToExternalUsers { get; set; }

        public bool UserPreferencesShowPostalCodeToExternalUsers { get; set; }

        public bool UserPreferencesShowCountryToExternalUsers { get; set; }

        public bool UserPreferencesShowProfilePicToGuestUsers { get; set; }

        public bool UserPreferencesShowTitleToGuestUsers { get; set; }

        public bool UserPreferencesShowCityToGuestUsers { get; set; }

        public bool UserPreferencesShowStateToGuestUsers { get; set; }

        public bool UserPreferencesShowPostalCodeToGuestUsers { get; set; }

        public bool UserPreferencesShowCountryToGuestUsers { get; set; }

        public bool UserPreferencesDisableFeedbackEmail { get; set; }

        public bool UserPreferencesDisableWorkEmail { get; set; }

        public bool UserPreferencesHideS1BrowserUI { get; set; }

        public bool UserPreferencesDisableEndorsementEmail { get; set; }

        [Url]
        public string FullPhotoUrl { get; set; }

        [Url]
        public string SmallPhotoUrl { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

    }
}
