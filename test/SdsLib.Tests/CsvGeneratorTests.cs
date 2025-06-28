using SdsLib.CsvGeneration;
using SdsLib.Domain;
using SdsLib.Domain.Enums;

namespace SdsLib.Tests;

public class CsvGeneratorTests
{
    [Test]
    public async Task GenerateCsv_VerifyGeneratedFiles()
    {
        // Arrange: Create a temporary directory and sample roster data
        var tempDir = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        var roster = getExampleRoster();
        var generator = new CsvGenerator(tempDir);

        // Act: Generate CSV files
        generator.GenerateCsv(roster);

        // Assert: Verify the generated directory
        await VerifyDirectory(tempDir);

        // Cleanup: Delete the temporary directory
        Directory.Delete(tempDir, true);
    }

    private Roster getExampleRoster() => new()
    {
        Orgs = [new Organization { SourcedId = "Org1", Name = "Test Org", Type = OrganizationType.School }],
        Users = [
            new User { SourcedId = "User1", Username = "teststudent", FamilyName = "Student", GivenName = "Test", Email = "teststudent@email.com", Phone = "123456789", Sms = "9876543210", UserNumber = "test-s1" },
            new User { SourcedId = "User2", Username = "testteacher", FamilyName = "Teacher", GivenName = "Test", UserNumber = "test-t1" },
            new User { SourcedId = "User3", Username = "testparent", FamilyName = "Parent", GivenName = "Test", UserNumber = "test-p1" },
        ],
        Roles = [
            new Role { UserSourcedId = "User1", OrgSourcedId = "Org1", RoleType = OrganizationRole.Student, SessionSourcedIds = ["Session1"], Grade = GradeLevel.EighthGrade, IsPrimary = true, RoleStartDate = new DateTime(2025, 8, 1), RoleEndDate = new DateTime(2026, 5, 31), },
            new Role { UserSourcedId = "User2", OrgSourcedId = "Org1", RoleType = OrganizationRole.Teacher },
        ],
        Classes = [new Class { SourcedId = "Class1", OrgSourcedId = "Org1", Title = "Test Class", Code = "TC101", CourseSourcedId = "Course1", SessionSourcedIds = ["Session1"] }],
        Enrollments = [
            new Enrollment { ClassSourcedId = "Class1", UserSourcedId = "User1", Role = EnrollmentRole.Student },
            new Enrollment { ClassSourcedId = "Class1", UserSourcedId = "User2", Role = EnrollmentRole.Teacher },
        ],
        AcademicSessions = [new AcademicSession { SourcedId = "Session1", Title = "Year 2025", Type = AcademicSessionType.SchoolYear, SchoolYear = SchoolYear.Year2025, StartDate = new DateTime(2025, 8, 1), EndDate = new DateTime(2026, 5, 31) }],
        Courses = [new Course { SourcedId = "Course1", OrgSourcedId = "Org1", Title = "Test Course", Code = "TC101", Grade = GradeLevel.EighthGrade, SchoolYearSourcedId = "Session1", Subject = Subject.Mathematics }],
        Relationships = [new Relationship { UserSourcedId = "User3", RelationshipUserSourcedId = "User2", RelationshipRole = ContactRelationshipRole.Parent }],
        Demographics = [new Demographic { UserSourcedId = "User1", Sex = DemographicGender.Male, BirthDate = new DateTime(2010, 5, 15), BirthCity = "Test City", BirthState = DemographicBirthState.AK, BirthCountry = "USA", EthnicityCodes = [DemographicEthnicity.HispanicOrLatinoEthnicity], RaceCodes = [DemographicRace.White, DemographicRace.Asian] }],
        UserFlags = [new UserFlag { UserSourcedId = "User1", Flag = PersonFlag.EnglishLanguageLearner }]
    };
}
