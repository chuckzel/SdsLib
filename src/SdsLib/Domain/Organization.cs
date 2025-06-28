namespace SdsLib.Domain;

using SdsLib.Domain.Enums;

public class Organization
{
    public required string SourcedId { get; init; } // sourcedId (required)
    public required string Name { get; init; } // name (required)
    public required OrganizationType Type { get; init; } // type (required)
    public string? ParentSourcedId { get; init; } // parentSourcedId (optional)
}
