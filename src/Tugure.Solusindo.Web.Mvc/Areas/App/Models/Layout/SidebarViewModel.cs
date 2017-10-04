using Abp.Application.Navigation;

namespace Tugure.Solusindo.Web.Areas.App.Models.Layout
{
    public class SidebarViewModel
    {
        public UserMenu Menu { get; set; }

        public string CurrentPageName { get; set; }
    }
}