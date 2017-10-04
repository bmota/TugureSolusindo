using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tugure.Solusindo.MultiTenancy.HostDashboard.Dto;

namespace Tugure.Solusindo.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}