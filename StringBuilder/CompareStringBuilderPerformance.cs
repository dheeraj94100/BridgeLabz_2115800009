using System;
using System.Diagnostics;
using System.Text;

class CompareStringBuilderPerformance
{
    static void Main()
    {
        Console.Write("Enter the number of iterations: ");
        int iterations = int.Parse(Console.ReadLine());

        Console.Write("Enter the test string: ");
        string testString = Console.ReadLine();

        // Measure time for String concatenation
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        string result = string.Empty;
        for (int i = 0; i < iterations; i++)
        {
            result += testString;
        }
        stopwatch.Stop();
        Console.WriteLine("String concatenation time: " + stopwatch.ElapsedMilliseconds + " ms");

        // Measure time for StringBuilder concatenation
        stopwatch.Reset();
        stopwatch.Start();
        StringBuilder stringBuilder = new StringBuilder();
        for (int i = 0; i < iterations; i++)
        {
            stringBuilder.Append(testString);
        }
        stopwatch.Stop();
        Console.WriteLine("StringBuilder concatenation time: " + stopwatch.ElapsedMilliseconds + " ms");
    }
}