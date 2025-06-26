using CsvHelper.Configuration;
using SdsLib.Domain;

namespace SdsLib.CsvGeneration.ClassMaps;

public class EnrollmentCsvMap : ClassMap<Enrollment>
{
    public EnrollmentCsvMap()
    {
        Map(m => m.ClassSourcedId).Name("classSourcedId");
        Map(m => m.UserSourcedId).Name("userSourcedId");
        Map(m => m.Role).Name("role");
    }
}
