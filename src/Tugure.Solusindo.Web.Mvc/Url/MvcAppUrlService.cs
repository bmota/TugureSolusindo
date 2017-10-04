using Abp.MultiTenancy;
using Tugure.Solusindo.Url;

namespace Tugure.Solusindo.Web.Url
{
    public class MvcAppUrlService : AppUrlServiceBase
    {
        public override string EmailActivationRoute => "Account/EmailConfirmation";

        public override string PasswordResetRoute => "Account/ResetPassword";

        public MvcAppUrlService(
                IWebUrlService webUrlService,
                ITenantCache tenantCache
            ) : base(
                webUrlService,
                tenantCache
            )
        {

        }
    }
}