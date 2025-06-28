using CsvHelper.Configuration;
using SdsLib.Domain;

namespace SdsLib.CsvGeneration.ClassMaps;

public class OrgCsvMap : ClassMap<Organization>
{
    public OrgCsvMap()
    {
        Map(m => m.SourcedId).Name("sourcedId");
        Map(m => m.Name).Name("name");
        Map(m => m.Type).Name("type");
        Map(m => m.ParentSourcedId).Name("parentSourcedId");
    }
}
