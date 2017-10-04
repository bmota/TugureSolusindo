using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using Tugure.Solusindo.Web.Areas.App.Models.Common.Modals;
using Tugure.Solusindo.Web.Controllers;

namespace Tugure.Solusindo.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize]
    public class CommonController : SolusindoControllerBase
    {
        public PartialViewResult LookupModal(LookupModalViewModel model)
        {
            return PartialView("Modals/_LookupModal", model);
        }
    }
}