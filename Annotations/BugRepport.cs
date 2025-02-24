using System;
using System.Reflection;

// Define a repeatable attribute
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class BugReportAttribute : Attribute
{
    public string Description { get; }

    public BugReportAttribute(string description)
    {
        Description = description;
    }
}

class Software
{
    // Applying the BugReport attribute multiple times
    [BugReport("Null reference exception in edge cases.")]
    [BugReport("Performance issue when processing large data.")]
    public void ProcessData()
    {
        Console.WriteLine("Processing data...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Software software = new Software();
        software.ProcessData();

        // Using reflection to retrieve all BugReport attributes
        MethodInfo methodInfo = typeof(Software).GetMethod("ProcessData");
        var bugReports = methodInfo.GetCustomAttributes<BugReportAttribute>();

        Console.WriteLine("\nBug Reports:");
        foreach (var bug in bugReports)
        {
            Console.WriteLine($"- {bug.Description}");
        }
    }
}
