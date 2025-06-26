using CsvHelper.Configuration;
using SdsLib.Domain;

namespace SdsLib.CsvGeneration.ClassMaps;

public class DemographicCsvMap : ClassMap<Demographic>
{
    public DemographicCsvMap()
    {
        Map(m => m.UserSourcedId).Name("userSourcedId");
        Map(m => m.Sex).Name("sex");
        Map(m => m.BirthDate).Name("birthDate");
        Map(m => m.EthnicityCodes).Name("ethnicityCodes");
        Map(m => m.RaceCodes).Name("raceCodes");
        Map(m => m.BirthState).Name("birthState");
        Map(m => m.BirthCity).Name("birthCity");
        Map(m => m.BirthCountry).Name("birthCountry");
    }
}
