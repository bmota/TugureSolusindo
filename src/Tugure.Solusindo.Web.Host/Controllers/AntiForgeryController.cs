using Microsoft.AspNetCore.Antiforgery;

namespace Tugure.Solusindo.Web.Controllers
{
    public class AntiForgeryController : SolusindoControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
