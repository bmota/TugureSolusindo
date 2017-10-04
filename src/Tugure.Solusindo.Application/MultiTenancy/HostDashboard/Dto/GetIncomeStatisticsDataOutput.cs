using System.Collections.Generic;

namespace Tugure.Solusindo.MultiTenancy.HostDashboard.Dto
{
    public class GetIncomeStatisticsDataOutput
    {
        public List<IncomeStastistic> IncomeStatistics { get; set; }

        public GetIncomeStatisticsDataOutput(List<IncomeStastistic> incomeStatistics)
        {
            IncomeStatistics = incomeStatistics;
        }
    }
}