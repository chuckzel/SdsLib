namespace SdsLib.Domain;

public class Class
{
    public required string SourcedId { get; init; } // sourcedId (required)
    public required string OrgSourcedId { get; init; } // orgSourcedId (required)
    public required string Title { get; init; } // title (required)
    public IEnumerable<string>? SessionSourcedIds { get; init; } // sessionSourcedIds (optional)
    public string? CourseSourcedId { get; init; } // courseSourcedId (optional)
    public string? Code { get; init; } // code (optional)
}
