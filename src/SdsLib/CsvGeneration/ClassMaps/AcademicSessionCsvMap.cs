using CsvHelper.Configuration;
using SdsLib.Domain;

namespace SdsLib.CsvGeneration.ClassMaps;

public class AcademicSessionCsvMap : ClassMap<AcademicSession>
{
    public AcademicSessionCsvMap()
    {
        Map(m => m.SourcedId).Name("sourcedId");
        Map(m => m.Title).Name("title");
        Map(m => m.Type).Name("type");
        Map(m => m.SchoolYear).Name("schoolYear");
        Map(m => m.StartDate).Name("startDate");
        Map(m => m.EndDate).Name("endDate");
    }
}
