namespace SdsLib.Domain;

using SdsLib.Domain.Enums;

public class Role
{
    public required string UserId { get; init; } // userSourcedId (required)
    public required string OrgId { get; init; } // orgSourcedId (required)
    public required RoleType RoleName { get; init; } // role (required)
    public IEnumerable<string>? SessionSourcedIds { get; init; } // sessionSourcedIds (optional)
    public GradeLevel? Grade { get; init; } // grade (optional)
    public string? IsPrimary { get; init; } // isPrimary (optional)
    public DateTime? RoleStartDate { get; init; } // roleStartDate (optional)
    public DateTime? RoleEndDate { get; init; } // roleEndDate (optional)
}
