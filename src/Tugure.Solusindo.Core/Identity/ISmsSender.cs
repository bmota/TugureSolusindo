using System.Threading.Tasks;

namespace Tugure.Solusindo.Identity
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}