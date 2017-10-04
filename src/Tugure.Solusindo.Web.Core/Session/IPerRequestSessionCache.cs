using System.Threading.Tasks;
using Tugure.Solusindo.Sessions.Dto;

namespace Tugure.Solusindo.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
