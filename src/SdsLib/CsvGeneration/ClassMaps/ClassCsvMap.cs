using CsvHelper.Configuration;
using SdsLib.Domain;

namespace SdsLib.CsvGeneration.ClassMaps;

public class ClassCsvMap : ClassMap<Class>
{
    public ClassCsvMap()
    {
        Map(m => m.SourcedId).Name("sourcedId");
        Map(m => m.OrgSourcedId).Name("orgSourcedId");
        Map(m => m.Title).Name("title");
        Map(m => m.Code).Name("code");
        Map(m => m.CourseSourcedId).Name("courseSourcedId");
        Map(m => m.SessionSourcedIds).Name("sessionSourcedIds");
    }
}
