namespace SdsLib.Domain;

using SdsLib.Domain.Enums;

public class Demographic
{
    public required string UserSourcedId { get; init; } // userSourcedId (required)
    public DemographicGender? Sex { get; init; } // sex (optional)
    public DateTime? BirthDate { get; init; } // birthDate (optional)
    public DemographicBirthState? BirthState { get; init; } // birthState (optional)
    public string? BirthCity { get; init; } // birthCity (optional)
    public string? BirthCountry { get; init; } // birthCountry (optional)
    public IEnumerable<DemographicEthnicity>? EthnicityCodes { get; init; } // ethnicityCodes (optional)
    public IEnumerable<DemographicRace>? RaceCodes { get; init; } // raceCodes (optional)
}
