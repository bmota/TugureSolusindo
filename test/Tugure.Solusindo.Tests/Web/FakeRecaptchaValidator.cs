using System.Threading.Tasks;
using Tugure.Solusindo.Security.Recaptcha;

namespace Tugure.Solusindo.Tests.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}
