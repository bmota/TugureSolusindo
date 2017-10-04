using System.ComponentModel.DataAnnotations;

namespace Tugure.Solusindo.Web.Models.Account
{
    public class SendPasswordResetLinkViewModel
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}