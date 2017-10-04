using Abp.AutoMapper;
using Tugure.Solusindo.MultiTenancy.Dto;

namespace Tugure.Solusindo.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(RegisterTenantOutput))]
    public class TenantRegisterResultViewModel : RegisterTenantOutput
    {
        public string TenantLoginAddress { get; set; }
    }
}