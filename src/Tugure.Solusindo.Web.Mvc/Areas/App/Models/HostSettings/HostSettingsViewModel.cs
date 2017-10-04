﻿using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Tugure.Solusindo.Configuration.Host.Dto;
using Tugure.Solusindo.Editions.Dto;

namespace Tugure.Solusindo.Web.Areas.App.Models.HostSettings
{
    public class HostSettingsViewModel
    {
        public HostSettingsEditDto Settings { get; set; }

        public List<SubscribableEditionComboboxItemDto> EditionItems { get; set; }

        public List<ComboboxItemDto> TimezoneItems { get; set; }
    }
}