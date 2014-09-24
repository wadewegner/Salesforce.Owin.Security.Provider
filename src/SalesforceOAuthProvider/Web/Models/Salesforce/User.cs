using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class User
    {
        [Key]
        public string Id { get; set; }

        [StringLength(80)]
        public string Username { get; set; }

        [StringLength(80)]
        public string LastName { get; set; }

        [StringLength(40)]
        public string FirstName { get; set; }

        [StringLength(121)]
        public string Name { get; set; }

        [StringLength(80)]
        public string CompanyName { get; set; }

        [StringLength(80)]
        public string Division { get; set; }

        [StringLength(80)]
        public string Department { get; set; }

        [StringLength(80)]
        public string Title { get; set; }

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

        [EmailAddress]
        public string Email { get; set; }

        public bool EmailPreferencesAutoBcc { get; set; }

        public bool EmailPreferencesAutoBccStayInTouch { get; set; }

        public bool EmailPreferencesStayInTouchReminder { get; set; }

        [EmailAddress]
        public string SenderEmail { get; set; }

        [StringLength(80)]
        public string SenderName { get; set; }

        [StringLength(1333)]
        public string Signature { get; set; }

        [StringLength(80)]
        public string StayInTouchSubject { get; set; }

        [StringLength(512)]
        public string StayInTouchSignature { get; set; }

        [StringLength(512)]
        public string StayInTouchNote { get; set; }

        [Phone]
        public string Phone { get; set; }

        [Phone]
        public string Fax { get; set; }

        [Phone]
        public string MobilePhone { get; set; }

        [StringLength(8)]
        public string Alias { get; set; }

        [StringLength(40)]
        public string CommunityNickname { get; set; }

        public bool IsBadged { get; set; }

        public bool IsActive { get; set; }

        public string TimeZoneSidKey { get; set; }

        public string UserRoleId { get; set; }

        public string LocaleSidKey { get; set; }

        public bool ReceivesInfoEmails { get; set; }

        public bool ReceivesAdminInfoEmails { get; set; }

        public string EmailEncodingKey { get; set; }

        public string ProfileId { get; set; }

        public string UserType { get; set; }

        public string LanguageLocaleKey { get; set; }

        [StringLength(20)]
        public string EmployeeNumber { get; set; }

        public string DelegatedApproverId { get; set; }

        public string ManagerId { get; set; }

        public DateTimeOffset? LastLoginDate { get; set; }

        public DateTimeOffset? LastPasswordChangeDate { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        public DateTimeOffset? OfflineTrialExpirationDate { get; set; }

        public DateTimeOffset? OfflinePdaTrialExpirationDate { get; set; }

        public bool UserPermissionsMarketingUser { get; set; }

        public bool UserPermissionsOfflineUser { get; set; }

        public bool UserPermissionsCallCenterAutoLogin { get; set; }

        public bool UserPermissionsMobileUser { get; set; }

        public bool UserPermissionsSFContentUser { get; set; }

        public bool UserPermissionsKnowledgeUser { get; set; }

        public bool UserPermissionsInteractionUser { get; set; }

        public bool UserPermissionsSupportUser { get; set; }

        public bool UserPermissionsJigsawProspectingUser { get; set; }

        public bool UserPermissionsSiteforceContributorUser { get; set; }

        public bool UserPermissionsSiteforcePublisherUser { get; set; }

        public bool UserPermissionsChatterAnswersUser { get; set; }

        public bool UserPermissionsWorkDotComUserFeature { get; set; }

        public bool ForecastEnabled { get; set; }

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

        public string ContactId { get; set; }

        public string AccountId { get; set; }

        public string CallCenterId { get; set; }

        [Phone]
        public string Extension { get; set; }

        [StringLength(512)]
        public string FederationIdentifier { get; set; }

        public string AboutMe { get; set; }

        [Url]
        public string FullPhotoUrl { get; set; }

        [Url]
        public string SmallPhotoUrl { get; set; }

        public string DigestFrequency { get; set; }

        public string DefaultGroupNotificationFrequency { get; set; }

        public int? JigsawImportLimitOverride { get; set; }

        public DateTimeOffset? LastViewedDate { get; set; }

        public DateTimeOffset? LastReferencedDate { get; set; }

    }
}
