using Abp.AutoMapper;
using Tugure.Solusindo.MultiTenancy.Payments;

namespace Tugure.Solusindo.Sessions.Dto
{
    [AutoMapFrom(typeof(SubscriptionPayment))]
    public class SubscriptionPaymentInfoDto
    {
        public decimal Amount { get; set; }
    }
}