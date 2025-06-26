using CsvHelper.Configuration;
using SdsLib.Domain;

namespace SdsLib.CsvGeneration.ClassMaps;

public class UserCsvMap : ClassMap<User>
{
    public UserCsvMap()
    {
        Map(m => m.SourcedId).Name("sourcedId");
        Map(m => m.Username).Name("username");
        Map(m => m.FamilyName).Name("familyName");
        Map(m => m.GivenName).Name("givenName");
        Map(m => m.Email).Name("email");
        Map(m => m.Phone).Name("phone");
        Map(m => m.Sms).Name("sms");
        Map(m => m.UserNumber).Name("userNumber");
    }
}
