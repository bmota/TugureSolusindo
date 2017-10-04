using System.ComponentModel.DataAnnotations;
using Tugure.Solusindo.Authorization.Users;

namespace Tugure.Solusindo.Configuration.Host.Dto
{
    public class SendTestEmailInput
    {
        [Required]
        [MaxLength(User.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }
    }
}