namespace SdsLib.Domain;

public record Roster
{
    public required IEnumerable<Org> Orgs { get; init; }
    public required IEnumerable<User> Users { get; init; }
    public required IEnumerable<Role> Roles { get; init; }
    public required IEnumerable<Class> Classes { get; init; }
    public required IEnumerable<Enrollment> Enrollments { get; init; }
}
