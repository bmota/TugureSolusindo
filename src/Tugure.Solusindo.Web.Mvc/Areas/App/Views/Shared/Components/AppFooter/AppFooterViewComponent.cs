using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tugure.Solusindo.Web.Areas.App.Models.Layout;
using Tugure.Solusindo.Web.Session;
using Tugure.Solusindo.Web.Views;

namespace Tugure.Solusindo.Web.Areas.App.Views.Shared.Components.AppFooter
{
    public class AppFooterViewComponent : SolusindoViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppFooterViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var footerModel = new FooterViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(footerModel);
        }
    }
}
