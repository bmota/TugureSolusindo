#if FEATURE_LDAP
using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using Tugure.Solusindo.Authorization.Users;
using Tugure.Solusindo.MultiTenancy;

namespace Tugure.Solusindo.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}
#endif