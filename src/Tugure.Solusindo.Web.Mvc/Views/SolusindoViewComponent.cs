using Abp.AspNetCore.Mvc.ViewComponents;

namespace Tugure.Solusindo.Web.Views
{
    public abstract class SolusindoViewComponent : AbpViewComponent
    {
        protected SolusindoViewComponent()
        {
            LocalizationSourceName = SolusindoConsts.LocalizationSourceName;
        }
    }
}