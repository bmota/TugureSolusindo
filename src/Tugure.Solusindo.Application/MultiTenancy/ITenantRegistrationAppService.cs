using System.Threading.Tasks;
using Abp.Application.Services;
using Tugure.Solusindo.Editions.Dto;
using Tugure.Solusindo.MultiTenancy.Dto;

namespace Tugure.Solusindo.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}