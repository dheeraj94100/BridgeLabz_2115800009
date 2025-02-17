using System;
using System.Diagnostics;
using System.Text;

class StringConcatenationPerformance
{
    static void Main()
    {
        int[] datasetSizes = { 1000, 10000, 1000000 };
        Random random = new Random();

        foreach (int size in datasetSizes)
        {
            string[] strings = new string[size];
            for (int i = 0; i < size; i++)
            {
                strings[i] = "a";
            }

            // Using string
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            string result = "";
            for (int i = 0; i < size; i++)
            {
                result += strings[i];
            }
            stopwatch.Stop();
            Console.WriteLine($"String concatenation time: {stopwatch.ElapsedMilliseconds} ms");

            // Using StringBuilder
            stopwatch.Restart();
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < size; i++)
            {
                stringBuilder.Append(strings[i]);
            }
            result = stringBuilder.ToString();
            stopwatch.Stop();
            Console.WriteLine($"StringBuilder concatenation time: {stopwatch.ElapsedMilliseconds} ms");

            // Using StringBuffer (not available in .NET)
        }
    }
}