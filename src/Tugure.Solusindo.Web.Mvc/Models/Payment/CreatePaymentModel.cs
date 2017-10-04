using Tugure.Solusindo.Editions;
using Tugure.Solusindo.MultiTenancy.Payments;

namespace Tugure.Solusindo.Web.Models.Payment
{
    public class CreatePaymentModel
    {
        public int EditionId { get; set; }

        public PaymentPeriodType? PaymentPeriodType { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }

        public SubscriptionPaymentGatewayType Gateway { get; set; }
    }
}
