using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Tugure.Solusindo.Editions.Dto;

namespace Tugure.Solusindo.MultiTenancy.Dto
{
    public class GetTenantFeaturesEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}