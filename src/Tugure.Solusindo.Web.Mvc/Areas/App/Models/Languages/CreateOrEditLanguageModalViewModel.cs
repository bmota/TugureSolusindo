using Abp.AutoMapper;
using Tugure.Solusindo.Localization.Dto;

namespace Tugure.Solusindo.Web.Areas.App.Models.Languages
{
    [AutoMapFrom(typeof(GetLanguageForEditOutput))]
    public class CreateOrEditLanguageModalViewModel : GetLanguageForEditOutput
    {
        public bool IsEditMode => Language.Id.HasValue;

        public CreateOrEditLanguageModalViewModel(GetLanguageForEditOutput output)
        {
            output.MapTo(this);
        }
    }
}