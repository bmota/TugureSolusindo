using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Tugure.Solusindo.Authentication.TwoFactor.Google;
using Tugure.Solusindo.Authorization;
using Tugure.Solusindo.Authorization.Roles;
using Tugure.Solusindo.Authorization.Users;
using Tugure.Solusindo.Editions;
using Tugure.Solusindo.MultiTenancy;

namespace Tugure.Solusindo.Identity
{
    public static class IdentityRegistrar
    {
        public static IdentityBuilder Register(IServiceCollection services)
        {
            services.AddLogging();

            return services.AddAbpIdentity<Tenant, User, Role>(options =>
                {
                    options.Tokens.ProviderMap[GoogleAuthenticatorProvider.Name] = new TokenProviderDescriptor(typeof(GoogleAuthenticatorProvider));
                })
                .AddAbpTenantManager<TenantManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddPermissionChecker<PermissionChecker>()
                .AddAbpSignInManager<SignInManager>()
                .AddDefaultTokenProviders();
        }
    }
}
