using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace Tugure.Solusindo.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
