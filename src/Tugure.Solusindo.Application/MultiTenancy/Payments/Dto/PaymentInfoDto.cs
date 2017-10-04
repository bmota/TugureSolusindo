using Tugure.Solusindo.Editions.Dto;

namespace Tugure.Solusindo.MultiTenancy.Payments.Dto
{
    public class PaymentInfoDto
    {
        public EditionSelectDto Edition { get; set; }

        public decimal AdditionalPrice { get; set; }
    }
}
