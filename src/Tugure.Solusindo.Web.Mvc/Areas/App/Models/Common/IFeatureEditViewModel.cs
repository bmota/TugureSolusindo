using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Tugure.Solusindo.Editions.Dto;

namespace Tugure.Solusindo.Web.Areas.App.Models.Common
{
    public interface IFeatureEditViewModel
    {
        List<NameValueDto> FeatureValues { get; set; }

        List<FlatFeatureDto> Features { get; set; }
    }
}