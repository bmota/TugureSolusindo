﻿using Tugure.Solusindo.Editions;
using Tugure.Solusindo.Editions.Dto;
using Tugure.Solusindo.MultiTenancy.Payments;
using Tugure.Solusindo.MultiTenancy.Payments.Dto;

namespace Tugure.Solusindo.Web.Models.Payment
{
    public class PaymentViewModel
    {
        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public decimal? AdditionalPrice { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }
        
        public string GetAdditionalData(SubscriptionPaymentGatewayType gateway, string key)
        {
            return Edition.AdditionalData[gateway][key];
        }

        public string GetFormArea()
        {
            if (EditionPaymentType == EditionPaymentType.NewRegistration)
            {
                return "";
            }
                   
            return "App";
        }

        public string GetFormPostController()
        {
            if (EditionPaymentType == EditionPaymentType.NewRegistration)
            {
                return "Payment";
            }

            return "SubscriptionManagement";
        }

        public string GetFormAction()
        {
            if (EditionPaymentType == EditionPaymentType.NewRegistration)
            {
                return "ExecutePayment";
            }

            return "PaymentResult";
        }

        public bool IsUpgrading()
        {
            return AdditionalPrice.HasValue && AdditionalPrice.Value > 0;
        }
    }
}
