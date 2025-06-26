namespace SdsLib.Domain;

using SdsLib.Domain.Enums;

public class UserFlag
{
    public required string UserSourcedId { get; init; } // userSourcedId (required)
    public required PersonFlag Flag { get; init; } // flag (required)
}
