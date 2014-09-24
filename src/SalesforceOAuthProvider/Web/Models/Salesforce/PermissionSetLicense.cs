using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class PermissionSetLicense
    {
        [Key]
        public string Id { get; set; }

        public bool IsDeleted { get; set; }

        [StringLength(80)]
        public string DeveloperName { get; set; }

        public string Language { get; set; }

        [StringLength(80)]
        public string MasterLabel { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        [StringLength(40)]
        public string PermissionSetLicenseKey { get; set; }

        public int TotalLicenses { get; set; }

        public string Status { get; set; }

        public DateTimeOffset? ExpirationDate { get; set; }

        public bool MaximumPermissionsEmailSingle { get; set; }

        public bool MaximumPermissionsEmailMass { get; set; }

        public bool MaximumPermissionsEditTask { get; set; }

        public bool MaximumPermissionsEditEvent { get; set; }

        public bool MaximumPermissionsExportReport { get; set; }

        public bool MaximumPermissionsImportPersonal { get; set; }

        public bool MaximumPermissionsManageUsers { get; set; }

        public bool MaximumPermissionsEditPublicTemplates { get; set; }

        public bool MaximumPermissionsModifyAllData { get; set; }

        public bool MaximumPermissionsManageCases { get; set; }

        public bool MaximumPermissionsMassInlineEdit { get; set; }

        public bool MaximumPermissionsEditKnowledge { get; set; }

        public bool MaximumPermissionsManageKnowledge { get; set; }

        public bool MaximumPermissionsManageSolutions { get; set; }

        public bool MaximumPermissionsCustomizeApplication { get; set; }

        public bool MaximumPermissionsEditReadonlyFields { get; set; }

        public bool MaximumPermissionsRunReports { get; set; }

        public bool MaximumPermissionsViewSetup { get; set; }

        public bool MaximumPermissionsTransferAnyEntity { get; set; }

        public bool MaximumPermissionsNewReportBuilder { get; set; }

        public bool MaximumPermissionsActivateContract { get; set; }

        public bool MaximumPermissionsActivateOrder { get; set; }

        public bool MaximumPermissionsImportLeads { get; set; }

        public bool MaximumPermissionsManageLeads { get; set; }

        public bool MaximumPermissionsTransferAnyLead { get; set; }

        public bool MaximumPermissionsViewAllData { get; set; }

        public bool MaximumPermissionsEditPublicDocuments { get; set; }

        public bool MaximumPermissionsEditBrandTemplates { get; set; }

        public bool MaximumPermissionsEditHtmlTemplates { get; set; }

        public bool MaximumPermissionsChatterInternalUser { get; set; }

        public bool MaximumPermissionsDeleteActivatedContract { get; set; }

        public bool MaximumPermissionsChatterInviteExternalUsers { get; set; }

        public bool MaximumPermissionsSendSitRequests { get; set; }

        public bool MaximumPermissionsManageRemoteAccess { get; set; }

        public bool MaximumPermissionsCanUseNewDashboardBuilder { get; set; }

        public bool MaximumPermissionsManageCategories { get; set; }

        public bool MaximumPermissionsConvertLeads { get; set; }

        public bool MaximumPermissionsPasswordNeverExpires { get; set; }

        public bool MaximumPermissionsUseTeamReassignWizards { get; set; }

        public bool MaximumPermissionsEditActivatedOrders { get; set; }

        public bool MaximumPermissionsInstallPackaging { get; set; }

        public bool MaximumPermissionsPublishPackaging { get; set; }

        public bool MaximumPermissionsChatterOwnGroups { get; set; }

        public bool MaximumPermissionsEditOppLineItemUnitPrice { get; set; }

        public bool MaximumPermissionsCreatePackaging { get; set; }

        public bool MaximumPermissionsBulkApiHardDelete { get; set; }

        public bool MaximumPermissionsSolutionImport { get; set; }

        public bool MaximumPermissionsManageCallCenters { get; set; }

        public bool MaximumPermissionsManageSynonyms { get; set; }

        public bool MaximumPermissionsViewContent { get; set; }

        public bool MaximumPermissionsManageEmailClientConfig { get; set; }

        public bool MaximumPermissionsEnableNotifications { get; set; }

        public bool MaximumPermissionsManageDataIntegrations { get; set; }

        public bool MaximumPermissionsDistributeFromPersWksp { get; set; }

        public bool MaximumPermissionsViewDataCategories { get; set; }

        public bool MaximumPermissionsManageDataCategories { get; set; }

        public bool MaximumPermissionsAuthorApex { get; set; }

        public bool MaximumPermissionsManageMobile { get; set; }

        public bool MaximumPermissionsApiEnabled { get; set; }

        public bool MaximumPermissionsManageCustomReportTypes { get; set; }

        public bool MaximumPermissionsEditCaseComments { get; set; }

        public bool MaximumPermissionsTransferAnyCase { get; set; }

        public bool MaximumPermissionsContentAdministrator { get; set; }

        public bool MaximumPermissionsCreateWorkspaces { get; set; }

        public bool MaximumPermissionsManageContentPermissions { get; set; }

        public bool MaximumPermissionsManageContentProperties { get; set; }

        public bool MaximumPermissionsManageContentTypes { get; set; }

        public bool MaximumPermissionsManageAnalyticSnapshots { get; set; }

        public bool MaximumPermissionsScheduleReports { get; set; }

        public bool MaximumPermissionsManageBusinessHourHolidays { get; set; }

        public bool MaximumPermissionsManageDynamicDashboards { get; set; }

        public bool MaximumPermissionsCustomSidebarOnAllPages { get; set; }

        public bool MaximumPermissionsManageInteraction { get; set; }

        public bool MaximumPermissionsViewMyTeamsDashboards { get; set; }

        public bool MaximumPermissionsModerateChatter { get; set; }

        public bool MaximumPermissionsResetPasswords { get; set; }

        public bool MaximumPermissionsFlowUFLRequired { get; set; }

        public bool MaximumPermissionsCanInsertFeedSystemFields { get; set; }

        public bool MaximumPermissionsManageKnowledgeImportExport { get; set; }

        public bool MaximumPermissionsEmailTemplateManagement { get; set; }

        public bool MaximumPermissionsEmailAdministration { get; set; }

        public bool MaximumPermissionsManageChatterMessages { get; set; }

        public bool MaximumPermissionsAllowEmailIC { get; set; }

        public bool MaximumPermissionsChatterFileLink { get; set; }

        public bool MaximumPermissionsForceTwoFactor { get; set; }

        public bool MaximumPermissionsManageNetworks { get; set; }

        public bool MaximumPermissionsManageAuthProviders { get; set; }

        public bool MaximumPermissionsRunFlow { get; set; }

        public bool MaximumPermissionsCreateCustomizeDashboards { get; set; }

        public bool MaximumPermissionsCreateDashboardFolders { get; set; }

        public bool MaximumPermissionsViewPublicDashboards { get; set; }

        public bool MaximumPermissionsManageDashbdsInPubFolders { get; set; }

        public bool MaximumPermissionsCreateCustomizeReports { get; set; }

        public bool MaximumPermissionsCreateReportFolders { get; set; }

        public bool MaximumPermissionsViewPublicReports { get; set; }

        public bool MaximumPermissionsManageReportsInPubFolders { get; set; }

        public bool MaximumPermissionsEditMyDashboards { get; set; }

        public bool MaximumPermissionsEditMyReports { get; set; }

        public bool MaximumPermissionsViewAllUsers { get; set; }

        public bool MaximumPermissionsAllowUniversalSearch { get; set; }

        public bool MaximumPermissionsConnectOrgToEnvironmentHub { get; set; }

        public bool MaximumPermissionsWorkCalibrationUser { get; set; }

        public bool MaximumPermissionsCreateCustomizeFilters { get; set; }

        public bool MaximumPermissionsWorkDotComUserPerm { get; set; }

        public bool MaximumPermissionsSalesConsole { get; set; }

        public bool MaximumPermissionsTwoFactorApi { get; set; }

        public bool MaximumPermissionsDeleteTopics { get; set; }

        public bool MaximumPermissionsEditTopics { get; set; }

        public bool MaximumPermissionsCreateTopics { get; set; }

        public bool MaximumPermissionsAssignTopics { get; set; }

        public bool MaximumPermissionsIdentityEnabled { get; set; }

        public bool MaximumPermissionsIdentityConnect { get; set; }

        public bool MaximumPermissionsAllowViewKnowledge { get; set; }

        public bool MaximumPermissionsCreateWorkBadgeDefinition { get; set; }

        public bool MaximumPermissionsCustomMobileAppsAccess { get; set; }

        public bool MaximumPermissionsViewHelpLink { get; set; }

        public int UsedLicenses { get; set; }

    }
}
