using System.Collections.Generic;
using Tugure.Solusindo.Organizations.Dto;

namespace Tugure.Solusindo.Web.Areas.App.Models.Common
{
    public interface IOrganizationUnitsEditViewModel
    {
        List<OrganizationUnitDto> AllOrganizationUnits { get; set; }

        List<string> MemberedOrganizationUnits { get; set; }
    }
}