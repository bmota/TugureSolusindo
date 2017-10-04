using System.ComponentModel.DataAnnotations;

namespace Tugure.Solusindo.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}