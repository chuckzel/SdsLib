namespace SdsLib.Domain;

using SdsLib.Domain.Enums;

public class Role
{
    public required string UserSourcedId { get; init; } // userSourcedId (required)
    public required string OrgSourcedId { get; init; } // orgSourcedId (required)
    public required OrganizationRole RoleType { get; init; } // role (required)
    public IEnumerable<string>? SessionSourcedIds { get; init; } // sessionSourcedIds (optional)
    public GradeLevel? Grade { get; init; } // grade (optional)
    public bool? IsPrimary { get; init; } // isPrimary (optional)
    public DateTime? RoleStartDate { get; init; } // roleStartDate (optional)
    public DateTime? RoleEndDate { get; init; } // roleEndDate (optional)
}
