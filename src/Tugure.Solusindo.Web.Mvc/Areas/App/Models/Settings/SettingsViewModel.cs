using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Tugure.Solusindo.Configuration.Tenants.Dto;

namespace Tugure.Solusindo.Web.Areas.App.Models.Settings
{
    public class SettingsViewModel
    {
        public TenantSettingsEditDto Settings { get; set; }
        
        public List<ComboboxItemDto> TimezoneItems { get; set; }
    }
}