using Abp.AutoMapper;
using Tugure.Solusindo.Authorization.Roles.Dto;
using Tugure.Solusindo.Web.Areas.App.Models.Common;

namespace Tugure.Solusindo.Web.Areas.App.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class CreateOrEditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool IsEditMode
        {
            get { return Role.Id.HasValue; }
        }

        public CreateOrEditRoleModalViewModel(GetRoleForEditOutput output)
        {
            output.MapTo(this);
        }
    }
}