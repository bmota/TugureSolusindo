﻿using Tugure.Solusindo.Editions;
using Tugure.Solusindo.Editions.Dto;
using Tugure.Solusindo.Security;
using Tugure.Solusindo.MultiTenancy.Payments;
using Tugure.Solusindo.MultiTenancy.Payments.Dto;

namespace Tugure.Solusindo.Web.Models.TenantRegistration
{
    public class TenantRegisterViewModel
    {
        public PasswordComplexitySetting PasswordComplexitySetting { get; set; }

        public int? EditionId { get; set; }

        public string PaymentId { get; set; }

        public SubscriptionPaymentGatewayType? Gateway { get; set; }

        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }

        public bool ShowPaymentExpireNotification()
        {
            return !string.IsNullOrEmpty(PaymentId);
        }
    }
}
