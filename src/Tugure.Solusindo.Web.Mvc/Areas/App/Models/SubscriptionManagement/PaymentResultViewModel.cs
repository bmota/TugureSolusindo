using Abp.AutoMapper;
using Tugure.Solusindo.Editions;
using Tugure.Solusindo.MultiTenancy.Payments.Dto;

namespace Tugure.Solusindo.Web.Areas.App.Models.SubscriptionManagement
{
    [AutoMapTo(typeof(ExecutePaymentDto))]
    public class PaymentResultViewModel : SubscriptionPaymentDto
    {
        public EditionPaymentType EditionPaymentType { get; set; }
    }
}