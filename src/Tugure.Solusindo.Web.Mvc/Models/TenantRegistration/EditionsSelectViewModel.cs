using Abp.AutoMapper;
using Tugure.Solusindo.MultiTenancy.Dto;

namespace Tugure.Solusindo.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(EditionsSelectOutput))]
    public class EditionsSelectViewModel : EditionsSelectOutput
    {
        public EditionsSelectViewModel(EditionsSelectOutput output)
        {
            output.MapTo(this);
        }
    }
}
