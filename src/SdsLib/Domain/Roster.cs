namespace SdsLib.Domain;

public record Roster
{
    public required IEnumerable<Organization> Orgs { get; init; }
    public required IEnumerable<User> Users { get; init; }
    public required IEnumerable<Role> Roles { get; init; }
    public IEnumerable<Class>? Classes { get; init; }
    public IEnumerable<Enrollment>? Enrollments { get; init; }
    public IEnumerable<AcademicSession>? AcademicSessions { get; init; }
    public IEnumerable<Course>? Courses { get; init; }
    public IEnumerable<Relationship>? Relationships { get; init; }
    public IEnumerable<Demographic>? Demographics { get; init; }
    public IEnumerable<UserFlag>? UserFlags { get; init; }
}
