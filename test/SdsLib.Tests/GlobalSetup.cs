[assembly: System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]

namespace SdsLib.Tests;

public class GlobalHooks
{
    [Before(TestSession)]
    public static void SetUp()
    {
        UseProjectRelativeDirectory("Snapshots");
    }
}