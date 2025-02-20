using System;
using System.Diagnostics;
using System.IO;

class BufferedStreams
{
    static void Main(string[] args)
    {
        string currentDirectory = Directory.GetCurrentDirectory();
        string sourceFile = Path.Combine(currentDirectory, "source.txt");
        string destFileBuffered = Path.Combine(currentDirectory, "destinationBuffered.txt");
        string destFileUnbuffered = Path.Combine(currentDirectory, "destinationUnbuffered.txt");

        // Copy using BufferedStream
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        CopyFileBuffered(sourceFile, destFileBuffered);
        stopwatch.Stop();
        Console.WriteLine($"BufferedStream copy time: {stopwatch.ElapsedMilliseconds} ms");

        // Copy using unbuffered FileStream
        stopwatch.Reset();
        stopwatch.Start();
        CopyFileUnbuffered(sourceFile, destFileUnbuffered);
        stopwatch.Stop();
        Console.WriteLine($"Unbuffered FileStream copy time: {stopwatch.ElapsedMilliseconds} ms");
    }

    static void CopyFileBuffered(string sourceFile, string destFile)
    {
        using (FileStream sourceStream = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
        using (FileStream destStream = new FileStream(destFile, FileMode.Create, FileAccess.Write))
        using (BufferedStream bufferedStream = new BufferedStream(destStream, 4096))
        {
            byte[] buffer = new byte[4096];
            int bytesRead;
            while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                bufferedStream.Write(buffer, 0, bytesRead);
            }
        }
    }

    static void CopyFileUnbuffered(string sourceFile, string destFile)
    {
        using (FileStream sourceStream = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
        using (FileStream destStream = new FileStream(destFile, FileMode.Create, FileAccess.Write))
        {
            byte[] buffer = new byte[4096];
            int bytesRead;
            while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                destStream.Write(buffer, 0, bytesRead);
            }
        }
    }
}