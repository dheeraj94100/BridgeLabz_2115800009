using System;
using System.Diagnostics;
using System.Reflection;

// Define the custom attribute
[AttributeUsage(AttributeTargets.Method)]
class LogExecutionTimeAttribute : Attribute { }

class PerformanceTester
{
    [LogExecutionTime]
    public void FastMethod()
    {
        Console.WriteLine("Executing FastMethod...");
        for (int i = 0; i < 100000; i++) { } // Simulating a quick operation
    }

    [LogExecutionTime]
    public void SlowMethod()
    {
        Console.WriteLine("Executing SlowMethod...");
        System.Threading.Thread.Sleep(500); // Simulating a slow operation
    }
}

class Program
{
    static void Main(string[] args)
    {
        PerformanceTester tester = new PerformanceTester();
        MeasureExecutionTime(tester, nameof(PerformanceTester.FastMethod));
        MeasureExecutionTime(tester, nameof(PerformanceTester.SlowMethod));
    }

    static void MeasureExecutionTime(object obj, string methodName)
    {
        MethodInfo method = obj.GetType().GetMethod(methodName);
        if (method.GetCustomAttribute<LogExecutionTimeAttribute>() != null)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            method.Invoke(obj, null);
            stopwatch.Stop();
            Console.WriteLine($"Execution Time for {methodName}: {stopwatch.ElapsedMilliseconds} ms\n");
        }
    }
}
