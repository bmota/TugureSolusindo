using Abp.Authorization;
using Tugure.Solusindo.Authorization.Roles;
using Tugure.Solusindo.Authorization.Users;

namespace Tugure.Solusindo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
