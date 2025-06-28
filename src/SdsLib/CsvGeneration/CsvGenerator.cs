using SdsLib.Domain;

namespace SdsLib.CsvGeneration;

public class CsvGenerator
{
    public string DirPath { get; init; }
    public CsvGenerator(string dirPath)
    {
        DirPath = dirPath;
    }

    public void GenerateCsv(Roster roster)
    {
        if (!Directory.Exists(DirPath))
        {
            Directory.CreateDirectory(DirPath);
        }
        WriteRecords("orgs.csv", roster.Orgs);
        WriteRecords("users.csv", roster.Users);
        WriteRecords("roles.csv", roster.Roles);
        WriteRecords("classes.csv", roster.Classes);
        WriteRecords("enrollments.csv", roster.Enrollments);
        WriteRecords("academicSessions.csv", roster.AcademicSessions);
        WriteRecords("courses.csv", roster.Courses);
        WriteRecords("relationships.csv", roster.Relationships);
        WriteRecords("demographics.csv", roster.Demographics);
        WriteRecords("userFlags.csv", roster.UserFlags);
    }

    private void WriteRecords<T>(string fileName, IEnumerable<T>? records)
    {
        if (records == null) return;

        var filePath = Path.Combine(DirPath, fileName);
        using var writer = new StreamWriter(filePath);
        using var csv = new CsvHelper.CsvWriter(writer, System.Globalization.CultureInfo.InvariantCulture);
        csv.Context.RegisterSdsClassMaps();
        csv.WriteRecords(records);
    }
}
