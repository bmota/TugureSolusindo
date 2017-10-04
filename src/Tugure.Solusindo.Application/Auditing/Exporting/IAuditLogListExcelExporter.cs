using System.Collections.Generic;
using Tugure.Solusindo.Auditing.Dto;
using Tugure.Solusindo.Dto;

namespace Tugure.Solusindo.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);
    }
}
