using Abp.Domain.Services;

namespace Tugure.Solusindo
{
    public abstract class SolusindoDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected SolusindoDomainServiceBase()
        {
            LocalizationSourceName = SolusindoConsts.LocalizationSourceName;
        }
    }
}
