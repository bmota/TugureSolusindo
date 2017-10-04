using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using Tugure.Solusindo.Web.Controllers;

namespace Tugure.Solusindo.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize]
    public class WelcomeController : SolusindoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}