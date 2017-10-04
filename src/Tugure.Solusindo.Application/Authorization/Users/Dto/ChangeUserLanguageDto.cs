using System.ComponentModel.DataAnnotations;

namespace Tugure.Solusindo.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
