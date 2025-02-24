using System;
using System.Diagnostics;
using System.Reflection;

public class MethodExecutionTiming
{
    public void Method1()
    {
        // Simulate some work
        System.Threading.Thread.Sleep(1000);
    }

    public void Method2()
    {
        // Simulate some work
        System.Threading.Thread.Sleep(2000);
    }

    public static void MeasureExecutionTime(object obj)
    {
        Type type = obj.GetType();
        MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

        foreach (var method in methods)
        {
            try
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                method.Invoke(obj, null);

                stopwatch.Stop();
                Console.WriteLine($"Execution time of {method.Name}: {stopwatch.ElapsedMilliseconds} ms");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while executing {method.Name}: {ex.Message}");
            }
        }
    }

    public static void Main(string[] args)
    {
        MethodExecutionTiming obj = new MethodExecutionTiming();
        MeasureExecutionTime(obj);
    }
}