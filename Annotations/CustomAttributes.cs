using System;
using System.Reflection;

// Define a custom attribute
[AttributeUsage(AttributeTargets.Method, Inherited = false)]
class TaskInfoAttribute : Attribute
{
    public int Priority { get; }
    public string AssignedTo { get; }

    public TaskInfoAttribute(int priority, string assignedTo)
    {
        Priority = priority;
        AssignedTo = assignedTo;
    }
}

class TaskManager
{
    // Applying custom attribute to a method
    [TaskInfo(1, "John Doe")]
    public void CompleteTask()
    {
        Console.WriteLine("Task completed.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        TaskManager taskManager = new TaskManager();
        taskManager.CompleteTask();

        // Using reflection to retrieve the attribute
        MethodInfo methodInfo = typeof(TaskManager).GetMethod("CompleteTask");
        if (methodInfo.GetCustomAttribute(typeof(TaskInfoAttribute)) is TaskInfoAttribute taskInfo)
        {
            Console.WriteLine($"Task Priority: {taskInfo.Priority}");
            Console.WriteLine($"Assigned To: {taskInfo.AssignedTo}");
        }
    }
}
