using CsvHelper.Configuration;
using SdsLib.Domain;

namespace SdsLib.CsvGeneration.ClassMaps;

public class RelationshipCsvMap : ClassMap<Relationship>
{
    public RelationshipCsvMap()
    {
        Map(m => m.UserSourcedId).Name("userSourcedId");
        Map(m => m.RelationshipUserSourcedId).Name("relationshipUserSourcedId");
        Map(m => m.RelationshipRole).Name("relationshipRole");
    }
}
