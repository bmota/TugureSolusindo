using Abp.AutoMapper;
using Tugure.Solusindo.Authorization.Users;
using Tugure.Solusindo.Authorization.Users.Dto;
using Tugure.Solusindo.Web.Areas.App.Models.Common;

namespace Tugure.Solusindo.Web.Areas.App.Models.Users
{
    [AutoMapFrom(typeof(GetUserPermissionsForEditOutput))]
    public class UserPermissionsEditViewModel : GetUserPermissionsForEditOutput, IPermissionsEditViewModel
    {
        public User User { get; private set; }

        public UserPermissionsEditViewModel(GetUserPermissionsForEditOutput output, User user)
        {
            User = user;
            output.MapTo(this);
        }
    }
}