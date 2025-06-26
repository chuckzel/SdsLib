using CsvHelper.Configuration;
using SdsLib.Domain;

namespace SdsLib.CsvGeneration.ClassMaps;

public class CourseCsvMap : ClassMap<Course>
{
    public CourseCsvMap()
    {
        Map(m => m.SourcedId).Name("sourcedId");
        Map(m => m.OrgSourcedId).Name("orgSourcedId");
        Map(m => m.Title).Name("title");
        Map(m => m.Code).Name("code");
        Map(m => m.SchoolYearSourcedId).Name("schoolYearSourcedId");
        Map(m => m.Subject).Name("subject");
    }
}
