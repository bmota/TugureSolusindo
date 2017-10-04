using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using Tugure.Solusindo.Authorization;
using Tugure.Solusindo.Web.Controllers;

namespace Tugure.Solusindo.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize(AppPermissions.Pages_Tenant_Dashboard)]
    public class DashboardController : SolusindoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}