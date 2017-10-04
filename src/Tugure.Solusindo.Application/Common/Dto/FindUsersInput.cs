using Tugure.Solusindo.Dto;

namespace Tugure.Solusindo.Common.Dto
{
    public class FindUsersInput : PagedAndFilteredInputDto
    {
        public int? TenantId { get; set; }
    }
}