using Abp.Auditing;
using Microsoft.AspNetCore.Mvc;

namespace Tugure.Solusindo.Web.Controllers
{
    public class HomeController : SolusindoControllerBase
    {
        [DisableAuditing]
        public IActionResult Index()
        {
            return Redirect("/swagger");
        }
    }
}
