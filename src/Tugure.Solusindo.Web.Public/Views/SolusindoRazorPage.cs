using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Tugure.Solusindo.Web.Public.Views
{
    public abstract class SolusindoRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected SolusindoRazorPage()
        {
            LocalizationSourceName = SolusindoConsts.LocalizationSourceName;
        }
    }
}
