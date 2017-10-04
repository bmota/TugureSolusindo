using Abp.AspNetCore.Mvc.Authorization;

namespace Tugure.Solusindo.Web.Controllers
{
    [AbpMvcAuthorize]
    public class ProfileController : ProfileControllerBase
    {
        public ProfileController(IAppFolders appFolders)
            : base(appFolders)
        {
        }
    }
}