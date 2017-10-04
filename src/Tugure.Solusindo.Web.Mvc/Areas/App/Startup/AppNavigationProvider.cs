using Abp.Application.Navigation;
using Abp.Localization;
using Tugure.Solusindo.Authorization;

namespace Tugure.Solusindo.Web.Areas.App.Startup
{
    public class AppNavigationProvider : NavigationProvider
    {
        public const string MenuName = "App";

        public override void SetNavigation(INavigationProviderContext context)
        {
            var menu = context.Manager.Menus[MenuName] = new MenuDefinition(MenuName, new FixedLocalizableString("Main Menu"));

            menu
                .AddItem(new MenuItemDefinition(
                        AppPageNames.Host.Dashboard,
                        L("Dashboard"),
                        url: "App/HostDashboard",
                        icon: "icon-home",
                        requiredPermissionName: AppPermissions.Pages_Administration_Host_Dashboard
                    )
                ).AddItem(new MenuItemDefinition(
                    AppPageNames.Host.Tenants,
                    L("Tenants"),
                    url: "App/Tenants",
                    icon: "icon-globe",
                    requiredPermissionName: AppPermissions.Pages_Tenants
                    )
                ).AddItem(new MenuItemDefinition(
                        AppPageNames.Host.Editions,
                        L("Editions"),
                        url: "App/Editions",
                        icon: "icon-grid",
                        requiredPermissionName: AppPermissions.Pages_Editions
                    )
                ).AddItem(new MenuItemDefinition(
                        AppPageNames.Tenant.Dashboard,
                        L("Dashboard"),
                        url: "App/Dashboard",
                        icon: "icon-home",
                        requiredPermissionName: AppPermissions.Pages_Tenant_Dashboard
                    )
                ).AddItem(new MenuItemDefinition(
                        AppPageNames.Common.Administration,
                        L("Administration"),
                        icon: "icon-wrench"
                    ).AddItem(new MenuItemDefinition(
                            AppPageNames.Common.OrganizationUnits,
                            L("OrganizationUnits"),
                            url: "App/OrganizationUnits",
                            icon: "icon-layers",
                            requiredPermissionName: AppPermissions.Pages_Administration_OrganizationUnits
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppPageNames.Common.Roles,
                            L("Roles"),
                            url: "App/Roles",
                            icon: "icon-briefcase",
                            requiredPermissionName: AppPermissions.Pages_Administration_Roles
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppPageNames.Common.Users,
                            L("Users"),
                            url: "App/Users",
                            icon: "icon-people",
                            requiredPermissionName: AppPermissions.Pages_Administration_Users
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppPageNames.Common.Languages,
                            L("Languages"),
                            url: "App/Languages",
                            icon: "icon-flag",
                            requiredPermissionName: AppPermissions.Pages_Administration_Languages
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppPageNames.Common.AuditLogs,
                            L("AuditLogs"),
                            url: "App/AuditLogs",
                            icon: "icon-lock",
                            requiredPermissionName: AppPermissions.Pages_Administration_AuditLogs
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppPageNames.Host.Maintenance,
                            L("Maintenance"),
                            url: "App/Maintenance",
                            icon: "icon-wrench",
                            requiredPermissionName: AppPermissions.Pages_Administration_Host_Maintenance
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppPageNames.Tenant.SubscriptionManagement,
                            L("Subscription"),
                            url: "App/SubscriptionManagement",
                            icon: "icon-refresh"
                            ,
                            requiredPermissionName: AppPermissions.Pages_Administration_Tenant_SubscriptionManagement
                        )
                    )
                    .AddItem(new MenuItemDefinition(
                            AppPageNames.Host.Settings,
                            L("Settings"),
                            url: "App/HostSettings",
                            icon: "icon-settings",
                            requiredPermissionName: AppPermissions.Pages_Administration_Host_Settings
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppPageNames.Tenant.Settings,
                            L("Settings"),
                            url: "App/Settings",
                            icon: "icon-settings",
                            requiredPermissionName: AppPermissions.Pages_Administration_Tenant_Settings
                        )
                    )
                ).AddItem(new MenuItemDefinition(
                        AppPageNames.Common.DemoUiComponents,
                        L("DemoUiComponents"),
                        url: "App/DemoUiComponents",
                        icon: "icon-puzzle",
                        requiredPermissionName: AppPermissions.Pages_DemoUiComponents
                    )
                );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, SolusindoConsts.LocalizationSourceName);
        }
    }
}