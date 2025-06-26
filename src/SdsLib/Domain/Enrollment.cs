namespace SdsLib.Domain;

using SdsLib.Domain.Enums;

public class Enrollment
{
    public required string ClassSourcedId { get; init; } // classSourcedId (required)
    public required string UserSourcedId { get; init; } // userSourcedId (required)
    public required EnrollmentRole Role { get; init; } // role (required)
}
