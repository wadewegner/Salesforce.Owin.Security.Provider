using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class PermissionSet
    {
        [Key]
        public string Id { get; set; }

        [StringLength(80)]
        public string Name { get; set; }

        [StringLength(80)]
        public string Label { get; set; }

        public string UserLicenseId { get; set; }

        public string ProfileId { get; set; }

        public bool IsOwnedByProfile { get; set; }

        public bool PermissionsEmailSingle { get; set; }

        public bool PermissionsEmailMass { get; set; }

        public bool PermissionsEditTask { get; set; }

        public bool PermissionsEditEvent { get; set; }

        public bool PermissionsExportReport { get; set; }

        public bool PermissionsImportPersonal { get; set; }

        public bool PermissionsManageUsers { get; set; }

        public bool PermissionsEditPublicTemplates { get; set; }

        public bool PermissionsModifyAllData { get; set; }

        public bool PermissionsManageCases { get; set; }

        public bool PermissionsMassInlineEdit { get; set; }

        public bool PermissionsEditKnowledge { get; set; }

        public bool PermissionsManageKnowledge { get; set; }

        public bool PermissionsManageSolutions { get; set; }

        public bool PermissionsCustomizeApplication { get; set; }

        public bool PermissionsEditReadonlyFields { get; set; }

        public bool PermissionsRunReports { get; set; }

        public bool PermissionsViewSetup { get; set; }

        public bool PermissionsTransferAnyEntity { get; set; }

        public bool PermissionsNewReportBuilder { get; set; }

        public bool PermissionsActivateContract { get; set; }

        public bool PermissionsActivateOrder { get; set; }

        public bool PermissionsImportLeads { get; set; }

        public bool PermissionsManageLeads { get; set; }

        public bool PermissionsTransferAnyLead { get; set; }

        public bool PermissionsViewAllData { get; set; }

        public bool PermissionsEditPublicDocuments { get; set; }

        public bool PermissionsEditBrandTemplates { get; set; }

        public bool PermissionsEditHtmlTemplates { get; set; }

        public bool PermissionsChatterInternalUser { get; set; }

        public bool PermissionsDeleteActivatedContract { get; set; }

        public bool PermissionsChatterInviteExternalUsers { get; set; }

        public bool PermissionsSendSitRequests { get; set; }

        public bool PermissionsManageRemoteAccess { get; set; }

        public bool PermissionsCanUseNewDashboardBuilder { get; set; }

        public bool PermissionsManageCategories { get; set; }

        public bool PermissionsConvertLeads { get; set; }

        public bool PermissionsPasswordNeverExpires { get; set; }

        public bool PermissionsUseTeamReassignWizards { get; set; }

        public bool PermissionsEditActivatedOrders { get; set; }

        public bool PermissionsInstallPackaging { get; set; }

        public bool PermissionsPublishPackaging { get; set; }

        public bool PermissionsChatterOwnGroups { get; set; }

        public bool PermissionsEditOppLineItemUnitPrice { get; set; }

        public bool PermissionsCreatePackaging { get; set; }

        public bool PermissionsBulkApiHardDelete { get; set; }

        public bool PermissionsSolutionImport { get; set; }

        public bool PermissionsManageCallCenters { get; set; }

        public bool PermissionsManageSynonyms { get; set; }

        public bool PermissionsViewContent { get; set; }

        public bool PermissionsManageEmailClientConfig { get; set; }

        public bool PermissionsEnableNotifications { get; set; }

        public bool PermissionsManageDataIntegrations { get; set; }

        public bool PermissionsDistributeFromPersWksp { get; set; }

        public bool PermissionsViewDataCategories { get; set; }

        public bool PermissionsManageDataCategories { get; set; }

        public bool PermissionsAuthorApex { get; set; }

        public bool PermissionsManageMobile { get; set; }

        public bool PermissionsApiEnabled { get; set; }

        public bool PermissionsManageCustomReportTypes { get; set; }

        public bool PermissionsEditCaseComments { get; set; }

        public bool PermissionsTransferAnyCase { get; set; }

        public bool PermissionsContentAdministrator { get; set; }

        public bool PermissionsCreateWorkspaces { get; set; }

        public bool PermissionsManageContentPermissions { get; set; }

        public bool PermissionsManageContentProperties { get; set; }

        public bool PermissionsManageContentTypes { get; set; }

        public bool PermissionsManageAnalyticSnapshots { get; set; }

        public bool PermissionsScheduleReports { get; set; }

        public bool PermissionsManageBusinessHourHolidays { get; set; }

        public bool PermissionsManageDynamicDashboards { get; set; }

        public bool PermissionsCustomSidebarOnAllPages { get; set; }

        public bool PermissionsManageInteraction { get; set; }

        public bool PermissionsViewMyTeamsDashboards { get; set; }

        public bool PermissionsModerateChatter { get; set; }

        public bool PermissionsResetPasswords { get; set; }

        public bool PermissionsFlowUFLRequired { get; set; }

        public bool PermissionsCanInsertFeedSystemFields { get; set; }

        public bool PermissionsManageKnowledgeImportExport { get; set; }

        public bool PermissionsEmailTemplateManagement { get; set; }

        public bool PermissionsEmailAdministration { get; set; }

        public bool PermissionsManageChatterMessages { get; set; }

        public bool PermissionsAllowEmailIC { get; set; }

        public bool PermissionsChatterFileLink { get; set; }

        public bool PermissionsForceTwoFactor { get; set; }

        public bool PermissionsManageNetworks { get; set; }

        public bool PermissionsManageAuthProviders { get; set; }

        public bool PermissionsRunFlow { get; set; }

        public bool PermissionsCreateCustomizeDashboards { get; set; }

        public bool PermissionsCreateDashboardFolders { get; set; }

        public bool PermissionsViewPublicDashboards { get; set; }

        public bool PermissionsManageDashbdsInPubFolders { get; set; }

        public bool PermissionsCreateCustomizeReports { get; set; }

        public bool PermissionsCreateReportFolders { get; set; }

        public bool PermissionsViewPublicReports { get; set; }

        public bool PermissionsManageReportsInPubFolders { get; set; }

        public bool PermissionsEditMyDashboards { get; set; }

        public bool PermissionsEditMyReports { get; set; }

        public bool PermissionsViewAllUsers { get; set; }

        public bool PermissionsAllowUniversalSearch { get; set; }

        public bool PermissionsConnectOrgToEnvironmentHub { get; set; }

        public bool PermissionsWorkCalibrationUser { get; set; }

        public bool PermissionsCreateCustomizeFilters { get; set; }

        public bool PermissionsWorkDotComUserPerm { get; set; }

        public bool PermissionsSalesConsole { get; set; }

        public bool PermissionsTwoFactorApi { get; set; }

        public bool PermissionsDeleteTopics { get; set; }

        public bool PermissionsEditTopics { get; set; }

        public bool PermissionsCreateTopics { get; set; }

        public bool PermissionsAssignTopics { get; set; }

        public bool PermissionsIdentityEnabled { get; set; }

        public bool PermissionsIdentityConnect { get; set; }

        public bool PermissionsAllowViewKnowledge { get; set; }

        public bool PermissionsCreateWorkBadgeDefinition { get; set; }

        public bool PermissionsCustomMobileAppsAccess { get; set; }

        public bool PermissionsViewHelpLink { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        [StringLength(15)]
        public string NamespacePrefix { get; set; }

    }
}
