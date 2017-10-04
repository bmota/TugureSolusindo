using System.Collections.Generic;
using Abp.Application.Services.Dto;

namespace Tugure.Solusindo.Web.Areas.App.Models.Roles
{
    public class RoleListViewModel
    {
        public List<ComboboxItemDto> Permissions { get; set; }
    }
}