using CsvHelper.Configuration;
using SdsLib.Domain;

namespace SdsLib.CsvGeneration.ClassMaps;

public class RoleCsvMap : ClassMap<Role>
{
    public RoleCsvMap()
    {
        Map(m => m.UserId).Name("userSourcedId");
        Map(m => m.OrgId).Name("orgSourcedId");
        Map(m => m.RoleName).Name("role");
        Map(m => m.SessionSourcedIds).Name("sessionSourcedIds");
        Map(m => m.Grade).Name("grade");
        Map(m => m.IsPrimary).Name("isPrimary");
        Map(m => m.RoleStartDate).Name("roleStartDate");
        Map(m => m.RoleEndDate).Name("roleEndDate");
    }
}
