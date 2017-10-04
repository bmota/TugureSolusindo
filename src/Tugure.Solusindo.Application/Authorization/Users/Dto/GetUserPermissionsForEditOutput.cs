using System.Collections.Generic;
using Tugure.Solusindo.Authorization.Permissions.Dto;

namespace Tugure.Solusindo.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}