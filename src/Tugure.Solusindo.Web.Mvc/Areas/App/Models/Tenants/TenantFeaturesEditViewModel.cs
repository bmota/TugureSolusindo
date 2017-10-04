using Abp.AutoMapper;
using Tugure.Solusindo.MultiTenancy;
using Tugure.Solusindo.MultiTenancy.Dto;
using Tugure.Solusindo.Web.Areas.App.Models.Common;

namespace Tugure.Solusindo.Web.Areas.App.Models.Tenants
{
    [AutoMapFrom(typeof (GetTenantFeaturesEditOutput))]
    public class TenantFeaturesEditViewModel : GetTenantFeaturesEditOutput, IFeatureEditViewModel
    {
        public Tenant Tenant { get; set; }

        public TenantFeaturesEditViewModel(Tenant tenant, GetTenantFeaturesEditOutput output)
        {
            Tenant = tenant;
            output.MapTo(this);
        }
    }
}