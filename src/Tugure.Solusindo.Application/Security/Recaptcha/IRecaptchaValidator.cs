using System.Threading.Tasks;

namespace Tugure.Solusindo.Security.Recaptcha
{
    public interface IRecaptchaValidator
    {
        Task ValidateAsync(string captchaResponse);
    }
}