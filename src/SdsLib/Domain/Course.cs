namespace SdsLib.Domain;

using SdsLib.Domain.Enums;

public class Course
{
    public required string SourcedId { get; init; } // sourcedId (required)
    public required string OrgSourcedId { get; init; } // orgSourcedId (required)
    public required string Title { get; init; } // title (required)
    public string? Code { get; init; } // code (optional)
    public string? SchoolYearSourcedId { get; init; } // schoolYearSourcedId (optional)
    public Subject? Subject { get; init; } // subject (optional)
    public GradeLevel? Grade { get; init; } // grade (optional)
}
