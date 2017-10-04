using System.Collections.Generic;
using Tugure.Solusindo.Authorization.Permissions.Dto;

namespace Tugure.Solusindo.Web.Areas.App.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }

        List<string> GrantedPermissionNames { get; set; }
    }
}