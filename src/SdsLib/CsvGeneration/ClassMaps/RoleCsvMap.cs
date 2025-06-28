using CsvHelper.Configuration;
using SdsLib.Domain;

namespace SdsLib.CsvGeneration.ClassMaps;

public class RoleCsvMap : ClassMap<Role>
{
    public RoleCsvMap()
    {
        Map(m => m.UserSourcedId).Name("userSourcedId");
        Map(m => m.OrgSourcedId).Name("orgSourcedId");
        Map(m => m.RoleType).Name("role");
        Map(m => m.SessionSourcedIds).Name("sessionSourcedIds");
        Map(m => m.Grade).Name("grade");
        Map(m => m.IsPrimary).Name("isPrimary");
        Map(m => m.RoleStartDate).Name("roleStartDate");
        Map(m => m.RoleEndDate).Name("roleEndDate");
    }
}
