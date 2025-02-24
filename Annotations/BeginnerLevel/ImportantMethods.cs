using System;
using System.Reflection;

// Define the custom attribute
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
class ImportantMethodAttribute : Attribute
{
    public string Level { get; }

    public ImportantMethodAttribute(string level = "HIGH") // Default level is HIGH
    {
        Level = level;
    }
}

class Operations
{
    // Applying the ImportantMethod attribute
    [ImportantMethod]  // Uses default level "HIGH"
    public void CriticalTask()
    {
        Console.WriteLine("Executing a critical task...");
    }

    [ImportantMethod("MEDIUM")]
    public void RegularTask()
    {
        Console.WriteLine("Executing a regular task...");
    }

    public void UnmarkedTask()
    {
        Console.WriteLine("This task is not marked as important.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Operations operations = new Operations();
        operations.CriticalTask();
        operations.RegularTask();
        operations.UnmarkedTask();

        // Using reflection to find methods with ImportantMethod attribute
        MethodInfo[] methods = typeof(Operations).GetMethods();

        Console.WriteLine("\nImportant Methods:");
        foreach (var method in methods)
        {
            var attribute = method.GetCustomAttribute<ImportantMethodAttribute>();
            if (attribute != null)
            {
                Console.WriteLine($"- {method.Name} (Level: {attribute.Level})");
            }
        }
    }
}
