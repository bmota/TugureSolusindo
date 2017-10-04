using Abp;

namespace Tugure.Solusindo
{
    /// <summary>
    /// This class can be used as a base class for services in this application.
    /// It has some useful objects property-injected and has some basic methods most of services may need to.
    /// It's suitable for non domain nor application service classes.
    /// For domain services inherit <see cref="SolusindoDomainServiceBase"/>.
    /// For application services inherit SolusindoAppServiceBase.
    /// </summary>
    public abstract class SolusindoServiceBase : AbpServiceBase
    {
        protected SolusindoServiceBase()
        {
            LocalizationSourceName = SolusindoConsts.LocalizationSourceName;
        }
    }
}