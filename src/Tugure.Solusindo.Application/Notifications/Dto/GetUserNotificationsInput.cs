using Abp.Notifications;
using Tugure.Solusindo.Dto;

namespace Tugure.Solusindo.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }
    }
}