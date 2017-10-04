using Abp.AutoMapper;
using Tugure.Solusindo.Sessions.Dto;

namespace Tugure.Solusindo.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}