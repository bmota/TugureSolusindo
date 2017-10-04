using System.Collections.Generic;
using Tugure.Solusindo.Authorization.Users.Dto;
using Tugure.Solusindo.Dto;

namespace Tugure.Solusindo.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}