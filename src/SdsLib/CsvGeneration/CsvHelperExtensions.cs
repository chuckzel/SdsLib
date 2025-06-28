using CsvHelper;
using SdsLib.CsvGeneration.ClassMaps;

namespace SdsLib.CsvGeneration;

public static class CsvHelperExtensions
{
    public static void RegisterSdsClassMaps(this CsvContext context)
    {
        context.RegisterClassMap<OrgCsvMap>();
        context.RegisterClassMap<UserCsvMap>();
        context.RegisterClassMap<RoleCsvMap>();
        context.RegisterClassMap<ClassCsvMap>();
        context.RegisterClassMap<EnrollmentCsvMap>();
        context.RegisterClassMap<AcademicSessionCsvMap>();
        context.RegisterClassMap<CourseCsvMap>();
        context.RegisterClassMap<RelationshipCsvMap>();
        context.RegisterClassMap<DemographicCsvMap>();
        context.RegisterClassMap<UserFlagCsvMap>();
    }
}
