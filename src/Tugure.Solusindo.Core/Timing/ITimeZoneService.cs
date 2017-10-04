﻿using System.Threading.Tasks;
using Abp.Configuration;

namespace Tugure.Solusindo.Timing
{
    public interface ITimeZoneService
    {
        Task<string> GetDefaultTimezoneAsync(SettingScopes scope, int? tenantId);
    }
}
