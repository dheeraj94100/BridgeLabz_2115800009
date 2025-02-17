using System;
using System.IO;
using System.Diagnostics;

class LargeFileReadingEfficiency
{
    static void Main(string[] args)
    {
        string filePath = "a.txt";// Different file for different dataset size 1MB, 100MB, 500MB

        // Measure time taken by StreamReader
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        using (StreamReader reader = new StreamReader(filePath))
        {
            while (reader.Read() != -1) { }
        }
        stopwatch.Stop();
        Console.WriteLine($"StreamReader: {stopwatch.ElapsedMilliseconds} ms");

        // Measure time taken by FileStream
        stopwatch.Restart();
        using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            byte[] buffer = new byte[1024];
            while (fileStream.Read(buffer, 0, buffer.Length) > 0) { }
        }
        stopwatch.Stop();
        Console.WriteLine($"FileStream: {stopwatch.ElapsedMilliseconds} ms");
    }
}