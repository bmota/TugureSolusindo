using System.Threading.Tasks;

namespace Tugure.Solusindo.Security
{
    public interface IPasswordComplexitySettingStore
    {
        Task<PasswordComplexitySetting> GetSettingsAsync();
    }
}
