using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using Tugure.Solusindo.Authorization;
using Tugure.Solusindo.Web.Areas.App.Models.HostDashboard;
using Tugure.Solusindo.Web.Controllers;

namespace Tugure.Solusindo.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Host_Dashboard)]
    public class HostDashboardController : SolusindoControllerBase
    {
        private const int DashboardOnLoadReportDayCount = 7;

        public ActionResult Index()
        {
            return View(new HostDashboardViewModel(DashboardOnLoadReportDayCount));
        }
    }
}