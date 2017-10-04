using System.Threading.Tasks;
using Abp;
using Abp.Notifications;
using Tugure.Solusindo.Authorization.Users;
using Tugure.Solusindo.MultiTenancy;

namespace Tugure.Solusindo.Notifications
{
    public interface IAppNotifier
    {
        Task WelcomeToTheApplicationAsync(User user);

        Task NewUserRegisteredAsync(User user);

        Task NewTenantRegisteredAsync(Tenant tenant);

        Task SendMessageAsync(UserIdentifier user, string message, NotificationSeverity severity = NotificationSeverity.Info);
    }
}
