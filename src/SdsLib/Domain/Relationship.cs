namespace SdsLib.Domain;

using SdsLib.Domain.Enums;

public class Relationship
{
    public required string UserSourcedId { get; init; } // userSourcedId (required)
    public required string RelationshipUserSourcedId { get; init; } // relationshipUserSourcedId (required)
    public required ContactRelationshipRole RelationshipRole { get; init; } // relationshipRole (required)
}
