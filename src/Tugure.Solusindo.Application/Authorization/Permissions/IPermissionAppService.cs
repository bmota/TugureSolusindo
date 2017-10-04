using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Tugure.Solusindo.Authorization.Permissions.Dto;

namespace Tugure.Solusindo.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
