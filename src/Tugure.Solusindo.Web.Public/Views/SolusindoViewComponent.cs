using Abp.AspNetCore.Mvc.ViewComponents;

namespace Tugure.Solusindo.Web.Public.Views
{
    public abstract class SolusindoViewComponent : AbpViewComponent
    {
        protected SolusindoViewComponent()
        {
            LocalizationSourceName = SolusindoConsts.LocalizationSourceName;
        }
    }
}