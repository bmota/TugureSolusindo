using Abp.Application.Services;
using Tugure.Solusindo.Dto;
using Tugure.Solusindo.Logging.Dto;

namespace Tugure.Solusindo.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
