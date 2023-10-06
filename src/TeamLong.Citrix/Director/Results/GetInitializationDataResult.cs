using System.Collections.Generic;

namespace TeamLong.Citrix.Director.Results;

public class InitializationDataResult
{
    public Root GetInitializationDataResult { get; set; }

    public class Panels
    {
        /// <summary>
        /// </summary>
        public int ColSpan { get; set; }

        /// <summary>
        /// </summary>
        public string DetailedViewUrl { get; set; }

        /// <summary>
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        public string PluginError { get; set; }

        /// <summary>
        ///     自定义报告
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        public string Url { get; set; }
    }

    public class Rows
    {
        /// <summary>
        /// </summary>
        public List<Panels> Panels { get; set; }
    }

    public class AppManagement
    {
        /// <summary>
        /// </summary>
        public string __type { get; set; }

        /// <summary>
        /// </summary>
        public int NumberOfColumns { get; set; }

        /// <summary>
        /// </summary>
        public List<Rows> Rows { get; set; }
    }

    public class ClientDetails
    {
        /// <summary>
        /// </summary>
        public string __type { get; set; }

        /// <summary>
        /// </summary>
        public int NumberOfColumns { get; set; }

        /// <summary>
        /// </summary>
        public List<Rows> Rows { get; set; }
    }

    public class CloudAnalytics
    {
        /// <summary>
        /// </summary>
        public string __type { get; set; }

        /// <summary>
        /// </summary>
        public int NumberOfColumns { get; set; }

        /// <summary>
        /// </summary>
        public List<Rows> Rows { get; set; }
    }

    public class Configuration
    {
        /// <summary>
        /// </summary>
        public string __type { get; set; }

        /// <summary>
        /// </summary>
        public int NumberOfColumns { get; set; }

        /// <summary>
        /// </summary>
        public List<Rows> Rows { get; set; }
    }

    public class Dashboard
    {
        /// <summary>
        /// </summary>
        public string __type { get; set; }

        /// <summary>
        /// </summary>
        public int NumberOfColumns { get; set; }

        /// <summary>
        /// </summary>
        public List<Rows> Rows { get; set; }
    }

    public class MachineDetails
    {
        /// <summary>
        /// </summary>
        public string __type { get; set; }

        /// <summary>
        /// </summary>
        public int NumberOfColumns { get; set; }

        /// <summary>
        /// </summary>
        public List<Rows> Rows { get; set; }
    }

    public class TrendsJS
    {
        /// <summary>
        /// </summary>
        public string __type { get; set; }

        /// <summary>
        /// </summary>
        public int NumberOfColumns { get; set; }

        /// <summary>
        /// </summary>
        public List<Rows> Rows { get; set; }
    }

    public class Trends
    {
        /// <summary>
        /// </summary>
        public string __type { get; set; }

        /// <summary>
        /// </summary>
        public int NumberOfColumns { get; set; }

        /// <summary>
        /// </summary>
        public List<Rows> Rows { get; set; }
    }

    public class PluginEnabledPageDefinitions
    {
        /// <summary>
        /// </summary>
        public AppManagement AppManagement { get; set; }

        /// <summary>
        /// </summary>
        public ClientDetails ClientDetails { get; set; }

        /// <summary>
        /// </summary>
        public CloudAnalytics CloudAnalytics { get; set; }

        /// <summary>
        /// </summary>
        public Configuration Configuration { get; set; }

        /// <summary>
        /// </summary>
        public Dashboard Dashboard { get; set; }

        /// <summary>
        /// </summary>
        public MachineDetails MachineDetails { get; set; }

        /// <summary>
        /// </summary>
        public TrendsJS TrendsJS { get; set; }

        /// <summary>
        /// </summary>
        public Trends Trends { get; set; }
    }

    public class ActionAuthorizationData
    {
        /// <summary>
        /// </summary>
        public bool SendingMessage { get; set; }

        /// <summary>
        /// </summary>
        public bool Shadowing { get; set; }

        /// <summary>
        /// </summary>
        public bool EndingApplication { get; set; }

        /// <summary>
        /// </summary>
        public bool EndingProcess { get; set; }

        /// <summary>
        /// </summary>
        public bool VDiskReset { get; set; }

        /// <summary>
        /// </summary>
        public bool PowerControl { get; set; }

        /// <summary>
        /// </summary>
        public bool SessionControl { get; set; }

        /// <summary>
        /// </summary>
        public bool ProfileReset { get; set; }

        /// <summary>
        /// </summary>
        public bool MaintenanceMode { get; set; }

        /// <summary>
        /// </summary>
        public bool EditAlertPolicy { get; set; }

        /// <summary>
        /// </summary>
        public bool EditEmailServerConfiguration { get; set; }

        /// <summary>
        /// </summary>
        public bool DismissAlert { get; set; }

        /// <summary>
        /// </summary>
        public bool ProbeConfigurationActions { get; set; }

        /// <summary>
        /// </summary>
        public bool ProbeAgentConfigurationActions { get; set; }

        /// <summary>
        /// </summary>
        public bool DisconnectSession { get; set; }

        /// <summary>
        /// </summary>
        public bool StopSession { get; set; }

        /// <summary>
        /// </summary>
        public bool SendSessionMessage { get; set; }

        /// <summary>
        /// </summary>
        public bool ShadowSession { get; set; }

        /// <summary>
        /// </summary>
        public bool ResetUPMProfile { get; set; }

        /// <summary>
        /// </summary>
        public bool ResetRoamingProfile { get; set; }

        /// <summary>
        /// </summary>
        public bool UserManagement { get; set; }
    }

    public class FeatureToggleData
    {
        /// <summary>
        /// </summary>
        public bool ResourceUtilization { get; set; }

        /// <summary>
        /// </summary>
        public bool ProactiveNotificationsV2 { get; set; }

        /// <summary>
        /// </summary>
        public bool LogOnPerformanceV2 { get; set; }

        /// <summary>
        /// </summary>
        public bool OneMonthMonitorDataRetention { get; set; }

        /// <summary>
        /// </summary>
        public bool CustomReporting { get; set; }

        /// <summary>
        /// </summary>
        public bool AppCentricTroubleshooting { get; set; }

        /// <summary>
        /// </summary>
        public bool DiskUtilization { get; set; }

        /// <summary>
        /// </summary>
        public bool GpuMonitoring { get; set; }

        /// <summary>
        /// </summary>
        public bool ApplicationLaunchFailureTracking { get; set; }

        /// <summary>
        /// </summary>
        public bool MachineConsoleAccess { get; set; }

        /// <summary>
        /// </summary>
        public bool ApplicationDashboard { get; set; }

        /// <summary>
        /// </summary>
        public bool AppUsagePrediction { get; set; }

        /// <summary>
        /// </summary>
        public bool XDSecurityAnalyticsActions { get; set; }

        /// <summary>
        /// </summary>
        public bool LinuxVDAShadowing { get; set; }

        /// <summary>
        /// </summary>
        public bool RenderJSFailures { get; set; }

        /// <summary>
        /// </summary>
        public bool ApplicationProbing { get; set; }

        /// <summary>
        /// </summary>
        public bool FilterCsvExport { get; set; }

        /// <summary>
        /// </summary>
        public bool InteractiveSessionBreakdown { get; set; }

        /// <summary>
        /// </summary>
        public bool GPOLogonDurationBreakdown { get; set; }

        /// <summary>
        /// </summary>
        public bool JSTrends { get; set; }

        /// <summary>
        /// </summary>
        public bool HypervisorHealth { get; set; }

        /// <summary>
        /// </summary>
        public bool DirectorDaasSupport { get; set; }

        /// <summary>
        /// </summary>
        public bool DirectorUniversalClaims { get; set; }

        /// <summary>
        /// </summary>
        public bool RDSLicensingHealthDirector { get; set; }

        /// <summary>
        /// </summary>
        public bool ProfileLoadBreakdown { get; set; }

        /// <summary>
        /// </summary>
        public bool DirectorDaasDashboard { get; set; }

        /// <summary>
        /// </summary>
        public bool JSFilters { get; set; }

        /// <summary>
        /// </summary>
        public bool CloudAlerts { get; set; }

        /// <summary>
        /// </summary>
        public bool NetworkCloudIntegration { get; set; }

        /// <summary>
        /// </summary>
        public bool StartupMetrics { get; set; }

        /// <summary>
        /// </summary>
        public bool RDSAutoScaling { get; set; }

        /// <summary>
        /// </summary>
        public bool SmartScaleMonitoring { get; set; }

        /// <summary>
        /// </summary>
        public bool AutoReconnectBreakdown { get; set; }

        /// <summary>
        /// </summary>
        public bool DesktopProbing { get; set; }

        /// <summary>
        /// </summary>
        public bool PerformanceAnalytics { get; set; }

        /// <summary>
        /// </summary>
        public bool JSActivityManager { get; set; }

        /// <summary>
        /// </summary>
        public bool JSUserDetails { get; set; }

        /// <summary>
        /// </summary>
        public bool JSFiltersServer { get; set; }

        /// <summary>
        /// </summary>
        public bool JSAlerts { get; set; }

        /// <summary>
        /// </summary>
        public bool NoAlertsTitleBar { get; set; }

        /// <summary>
        /// </summary>
        public bool CvadCspSupport { get; set; }

        /// <summary>
        /// </summary>
        public bool DaasShadowingEnablement { get; set; }

        /// <summary>
        /// </summary>
        public bool DirectorCspEnablement { get; set; }

        /// <summary>
        /// </summary>
        public bool RtopChannel { get; set; }

        /// <summary>
        /// </summary>
        public bool JSMachineDetails { get; set; }

        /// <summary>
        /// </summary>
        public bool DaasAppAndConnectionFilter { get; set; }

        /// <summary>
        /// </summary>
        public bool PvsMachineMetrics { get; set; }

        /// <summary>
        /// </summary>
        public bool OptimizeDirectorApiCalls { get; set; }

        /// <summary>
        /// </summary>
        public bool JSMachineHistoricalUtilization { get; set; }

        /// <summary>
        /// </summary>
        public bool JSFiltersTroubleshooting { get; set; }

        /// <summary>
        /// </summary>
        public bool SendMessageForDaas { get; set; }

        /// <summary>
        /// </summary>
        public bool JSSearchViewForDaaS { get; set; }

        /// <summary>
        /// </summary>
        public bool VdaProcessDataFromDruid { get; set; }

        /// <summary>
        /// </summary>
        public bool JSDashboardForDaaS { get; set; }

        /// <summary>
        /// </summary>
        public bool DirectorLoadIndexTrendSplit { get; set; }

        /// <summary>
        /// </summary>
        public bool PerformanceAnalyticsVisibility { get; set; }

        /// <summary>
        /// </summary>
        public bool ConnectionFailureV2 { get; set; }

        /// <summary>
        /// </summary>
        public bool SessionsCountV2 { get; set; }

        /// <summary>
        /// </summary>
        public bool SearchUsersApiCancellation { get; set; }

        /// <summary>
        /// </summary>
        public bool UserSearchV2 { get; set; }

        /// <summary>
        /// </summary>
        public bool DirectorSessionLaunchPOI { get; set; }

        /// <summary>
        /// </summary>
        public bool UserSearchDB { get; set; }
    }

    public class LicenseAuthorizationData
    {
        /// <summary>
        /// </summary>
        public bool ExtendedTimeRange { get; set; }

        /// <summary>
        /// </summary>
        public bool VDIMachines { get; set; }

        /// <summary>
        /// </summary>
        public bool RDSMachines { get; set; }

        /// <summary>
        /// </summary>
        public bool HostedAppsUsage { get; set; }

        /// <summary>
        /// </summary>
        public bool DesktopUsage { get; set; }

        /// <summary>
        /// </summary>
        public bool SCOMNotifications { get; set; }

        /// <summary>
        /// </summary>
        public bool ProactiveNotifications { get; set; }
    }

    public class LicensedPluginsAuthorizationData
    {
        /// <summary>
        /// </summary>
        public bool Application { get; set; }

        /// <summary>
        /// </summary>
        public bool startupMetricsUD { get; set; }

        /// <summary>
        /// </summary>
        public bool xdhdxmonitor { get; set; }

        /// <summary>
        /// </summary>
        public bool hdxInsightUD { get; set; }

        /// <summary>
        /// </summary>
        public bool CloudAnalytics { get; set; }

        /// <summary>
        /// </summary>
        public bool Configuration { get; set; }

        /// <summary>
        /// </summary>
        public bool TrendsJSPanel { get; set; }

        /// <summary>
        /// </summary>
        public bool MachineUsage { get; set; }

        /// <summary>
        /// </summary>
        public bool ProbePerformance { get; set; }

        /// <summary>
        /// </summary>
        public bool CustomReport { get; set; }

        /// <summary>
        /// </summary>
        public bool hdxInsight { get; set; }
    }

    public class PageAuthorizationData
    {
        /// <summary>
        /// </summary>
        public bool Dashboard { get; set; }

        /// <summary>
        /// </summary>
        public bool Filters { get; set; }

        /// <summary>
        /// </summary>
        public bool HelpDesk { get; set; }

        /// <summary>
        /// </summary>
        public bool MachineDetails { get; set; }

        /// <summary>
        /// </summary>
        public bool Trends { get; set; }

        /// <summary>
        /// </summary>
        public bool UserDetails { get; set; }

        /// <summary>
        /// </summary>
        public bool EndpointHelpDesk { get; set; }

        /// <summary>
        /// </summary>
        public bool EndpointDetails { get; set; }

        /// <summary>
        /// </summary>
        public bool Alerts { get; set; }

        /// <summary>
        /// </summary>
        public bool AlertPolicies { get; set; }

        /// <summary>
        /// </summary>
        public bool SCOMNotifications { get; set; }

        /// <summary>
        /// </summary>
        public bool ApplicationDashboard { get; set; }

        /// <summary>
        /// </summary>
        public bool Configuration { get; set; }

        /// <summary>
        /// </summary>
        public bool DaasDashboard { get; set; }

        /// <summary>
        /// </summary>
        public bool CloudAnalyticsConfiguration { get; set; }
    }

    public class Sites
    {
        /// <summary>
        /// </summary>
        public ActionAuthorizationData ActionAuthorizationData { get; set; }

        /// <summary>
        /// </summary>
        public FeatureToggleData FeatureToggleData { get; set; }

        /// <summary>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        public bool IsPlatinum { get; set; }

        /// <summary>
        /// </summary>
        public LicenseAuthorizationData LicenseAuthorizationData { get; set; }

        /// <summary>
        /// </summary>
        public bool LicenseServerAlertsAvailable { get; set; }

        /// <summary>
        /// </summary>
        public LicensedPluginsAuthorizationData LicensedPluginsAuthorizationData { get; set; }

        /// <summary>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        public PageAuthorizationData PageAuthorizationData { get; set; }

        /// <summary>
        /// </summary>
        public List<string> UnavailablePlugins { get; set; }

        /// <summary>
        /// </summary>
        public bool UpgradeEnabled { get; set; }

        /// <summary>
        /// </summary>
        public string Version { get; set; }
    }

    public class UserPersonalizationData
    {
        /// <summary>
        /// </summary>
        public List<string> CustomApplicationInstancesViews { get; set; }

        /// <summary>
        /// </summary>
        public List<string> CustomConnectionsViews { get; set; }

        /// <summary>
        /// </summary>
        public List<string> CustomMachinesViews { get; set; }

        /// <summary>
        /// </summary>
        public List<string> CustomSessionsViews { get; set; }
    }

    public class VersionInfo
    {
        /// <summary>
        /// </summary>
        public string Build { get; set; }

        /// <summary>
        /// </summary>
        public string Version { get; set; }
    }

    public class Root
    {
        /// <summary>
        /// </summary>
        public string AdminName { get; set; }

        /// <summary>
        /// </summary>
        public bool CloudDeployment { get; set; }

        /// <summary>
        /// </summary>
        public bool EndpointSearchAvailable { get; set; }

        /// <summary>
        /// </summary>
        public int HighProfileUsageThreshold { get; set; }

        /// <summary>
        /// </summary>
        public int HighRDSLoadIndexThreshold { get; set; }

        /// <summary>
        /// </summary>
        public int HighRedirectedFolderUsageThreshold { get; set; }

        /// <summary>
        /// </summary>
        public int HighVDiskUsageThreshold { get; set; }

        /// <summary>
        /// </summary>
        public string IMAActionAuthorizationData { get; set; }

        /// <summary>
        /// </summary>
        public bool IMAEnabled { get; set; }

        /// <summary>
        /// </summary>
        public bool IsAnalyticsEnabled { get; set; }

        /// <summary>
        /// </summary>
        public bool IsInAppGuidesEnabled { get; set; }

        /// <summary>
        /// </summary>
        public bool IsSCOMManagementServerConfigured { get; set; }

        /// <summary>
        /// </summary>
        public PluginEnabledPageDefinitions PluginEnabledPageDefinitions { get; set; }

        /// <summary>
        /// </summary>
        public int ResourceUtilizationTrendsLast2HoursRange { get; set; }

        /// <summary>
        /// </summary>
        public bool SessionRecordingConfigured { get; set; }

        /// <summary>
        /// </summary>
        public int SessionTimeoutInMin { get; set; }

        /// <summary>
        /// </summary>
        public string SiteGroups { get; set; }

        /// <summary>
        /// </summary>
        public List<Sites> Sites { get; set; }

        /// <summary>
        /// </summary>
        public bool TaskManagerApplicationsAvailable { get; set; }

        /// <summary>
        /// </summary>
        public int TrendsLast24HoursRange { get; set; }

        /// <summary>
        /// </summary>
        public int TrendsLast2HoursRange { get; set; }

        /// <summary>
        /// </summary>
        public int TrendsLast7DaysRange { get; set; }

        /// <summary>
        /// </summary>
        public int TrendsLastMonthRange { get; set; }

        /// <summary>
        /// </summary>
        public bool UpgradeContainerEnabled { get; set; }

        /// <summary>
        /// </summary>
        public bool UpgradeNotification { get; set; }

        /// <summary>
        /// </summary>
        public UserPersonalizationData UserPersonalizationData { get; set; }

        /// <summary>
        /// </summary>
        public int UserSearchQueryDelay { get; set; }

        /// <summary>
        /// </summary>
        public VersionInfo VersionInfo { get; set; }
    }
}