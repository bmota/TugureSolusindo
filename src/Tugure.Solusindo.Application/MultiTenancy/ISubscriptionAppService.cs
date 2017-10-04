using System.Threading.Tasks;
using Abp.Application.Services;

namespace Tugure.Solusindo.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task UpgradeTenantToEquivalentEdition(int upgradeEditionId);
    }
}
