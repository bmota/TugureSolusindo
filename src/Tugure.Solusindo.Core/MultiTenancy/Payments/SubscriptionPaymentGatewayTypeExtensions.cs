using System;
using Tugure.Solusindo.MultiTenancy.Payments.Paypal;

namespace Tugure.Solusindo.MultiTenancy.Payments
{
    public static class SubscriptionPaymentGatewayTypeExtensions
    {
        public static SubscriptionPaymentStatus GetPaymentStatus(this SubscriptionPaymentGatewayType gateway, string externalPaymentStatus)
        {
            return gateway.CreatePaymentGatewayPaymentStatusConverter().ConvertToSubscriptionPaymentStatus(externalPaymentStatus);
        }

        private static IPaymentGatewayPaymentStatusConverter CreatePaymentGatewayPaymentStatusConverter(this SubscriptionPaymentGatewayType gateway)
        {
            switch (gateway)
            {
                case SubscriptionPaymentGatewayType.Paypal:
                    return new PayPalPaymentGatewayPaymentStatusConverter();
                default:
                    throw new Exception("Unknown payment gatwway: " + gateway);
            }
        }
    }
}