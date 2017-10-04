using System.Threading.Tasks;
using Abp.Application.Services;
using Tugure.Solusindo.Configuration.Host.Dto;

namespace Tugure.Solusindo.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
