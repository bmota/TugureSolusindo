using System.Threading.Tasks;
using Abp.Application.Services;
using Tugure.Solusindo.Configuration.Tenants.Dto;

namespace Tugure.Solusindo.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
