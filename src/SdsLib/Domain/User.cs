namespace SdsLib.Domain;

using SdsLib.Domain.Enums;

public class User
{
    public required string SourcedId { get; init; } // sourcedId (required)
    public required string Username { get; init; } // username (required)
    public required string FamilyName { get; init; } // familyName (required)
    public required string GivenName { get; init; } // givenName (required)
    public string? ActiveDirectoryMatchId { get; init; } // activeDirectoryMatchId (optional)
    public string? Email { get; init; } // email (optional)
    public string? Phone { get; init; } // phone (optional)
    public string? Sms { get; init; } // sms (optional)
    public string? UserNumber { get; init; } // userNumber (optional)
}
