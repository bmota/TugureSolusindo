using Microsoft.Extensions.Configuration;

namespace Tugure.Solusindo.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
