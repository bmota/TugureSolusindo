using System.Collections.Generic;
using Tugure.Solusindo.Authorization.Users.Dto;

namespace Tugure.Solusindo.Web.Areas.App.Models.Users
{
    public class UserLoginAttemptModalViewModel
    {
        public List<UserLoginAttemptDto> LoginAttempts { get; set; }
    }
}