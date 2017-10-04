using Tugure.Solusindo.Authorization.Accounts.Dto;

namespace Tugure.Solusindo.Web.Models.Account
{
    public class EmailConfirmationViewModel : ActivateEmailInput
    {
        /// <summary>
        /// Tenant id.
        /// </summary>
        public int? TenantId { get; set; }
    }
}