namespace SdsLib.Domain;

using SdsLib.Domain.Enums;

public class AcademicSession
{
    public required string SourcedId { get; init; } // sourcedId (required)
    public required string Title { get; init; } // title (required)
    public required AcademicSessionType Type { get; init; } // type (required)
    public SchoolYear? SchoolYear { get; init; } // schoolYear (optional)
    public DateTime? StartDate { get; init; } // startDate (optional)
    public DateTime? EndDate { get; init; } // endDate (optional)
}
