using System.Threading.Tasks;
using Abp.Application.Services;
using Tugure.Solusindo.MultiTenancy.Dto;
using Tugure.Solusindo.MultiTenancy.Payments.Dto;
using Abp.Application.Services.Dto;

namespace Tugure.Solusindo.MultiTenancy.Payments
{
    public interface IPaymentAppService : IApplicationService
    {
        Task<PaymentInfoDto> GetPaymentInfo(PaymentInfoInput input);

        Task<CreatePaymentResponse> CreatePayment(CreatePaymentDto input);

        Task<ExecutePaymentResponse> ExecutePayment(ExecutePaymentDto input);

        Task<PagedResultDto<SubscriptionPaymentListDto>> GetPaymentHistory(GetPaymentHistoryInput input);
    }
}
