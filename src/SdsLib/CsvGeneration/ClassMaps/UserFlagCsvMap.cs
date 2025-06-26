using CsvHelper.Configuration;
using SdsLib.Domain;

namespace SdsLib.CsvGeneration.ClassMaps;

public class UserFlagCsvMap : ClassMap<UserFlag>
{
    public UserFlagCsvMap()
    {
        Map(m => m.UserSourcedId).Name("userSourcedId");
        Map(m => m.Flag).Name("flag");
    }
}
