using Microsoft.AspNetCore.Mvc;
using Tugure.Solusindo.Web.Controllers;

namespace Tugure.Solusindo.Web.Public.Controllers
{
    public class AboutController : SolusindoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}