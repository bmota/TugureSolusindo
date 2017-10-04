using System.Collections.Generic;
using Tugure.Solusindo.Caching.Dto;

namespace Tugure.Solusindo.Web.Areas.App.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
    }
}