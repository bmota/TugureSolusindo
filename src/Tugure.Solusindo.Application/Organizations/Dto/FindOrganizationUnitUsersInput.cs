using Tugure.Solusindo.Dto;

namespace Tugure.Solusindo.Organizations.Dto
{
    public class FindOrganizationUnitUsersInput : PagedAndFilteredInputDto
    {
        public long OrganizationUnitId { get; set; }
    }
}
