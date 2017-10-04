using System.ComponentModel.DataAnnotations;

namespace Tugure.Solusindo.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}