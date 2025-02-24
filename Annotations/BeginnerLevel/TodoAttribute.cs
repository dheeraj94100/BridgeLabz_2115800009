using System;
using System.Reflection;

// Define the custom attribute
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class TodoAttribute : Attribute
{
    public string Task { get; }
    public string AssignedTo { get; }
    public string Priority { get; }

    public TodoAttribute(string task, string assignedTo, string priority = "MEDIUM")
    {
        Task = task;
        AssignedTo = assignedTo;
        Priority = priority;
    }
}

class Project
{
    [Todo("Implement user authentication", "Alice", "HIGH")]
    [Todo("Fix login bug", "Bob", "CRITICAL")]
    public void AuthenticationModule()
    {
        Console.WriteLine("Processing authentication module...");
    }

    [Todo("Optimize database queries", "Charlie")]
    public void DatabaseOptimization()
    {
        Console.WriteLine("Optimizing database queries...");
    }

    public void CompletedFeature()
    {
        Console.WriteLine("This feature is already implemented.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Project project = new Project();
        project.AuthenticationModule();
        project.DatabaseOptimization();
        project.CompletedFeature();

        // Using reflection to find methods with Todo attribute
        MethodInfo[] methods = typeof(Project).GetMethods();

        Console.WriteLine("\nPending Tasks:");
        foreach (var method in methods)
        {
            var todos = method.GetCustomAttributes<TodoAttribute>();
            foreach (var todo in todos)
            {
                Console.WriteLine($"- {method.Name}: {todo.Task}");
                Console.WriteLine($"  Assigned To: {todo.AssignedTo}, Priority: {todo.Priority}");
            }
        }
    }
}
