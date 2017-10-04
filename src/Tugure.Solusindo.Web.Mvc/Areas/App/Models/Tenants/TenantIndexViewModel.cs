using System.Collections.Generic;
using Tugure.Solusindo.Editions.Dto;

namespace Tugure.Solusindo.Web.Areas.App.Models.Tenants
{
    public class TenantIndexViewModel
    {
        public List<SubscribableEditionComboboxItemDto> EditionItems { get; set; }
    }
}