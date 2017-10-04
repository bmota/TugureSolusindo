using System.Threading.Tasks;
using Abp.Application.Services;
using Tugure.Solusindo.Sessions.Dto;

namespace Tugure.Solusindo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
