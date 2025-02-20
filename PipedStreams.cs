using System;
using System.IO;
using System.IO.Pipes;
using System.Threading;

class PipedStreams
{
    static void Main(string[] args)
    {
        using (var pipeStream = new AnonymousPipeServerStream(PipeDirection.Out, HandleInheritability.Inheritable))
        {
            Thread writerThread = new Thread(() => WriteData(pipeStream));
            writerThread.Start();

            using (var pipeClientStream = new AnonymousPipeClientStream(PipeDirection.In, pipeStream.GetClientHandleAsString()))
            {
                Thread readerThread = new Thread(() => ReadData(pipeClientStream));
                readerThread.Start();

                writerThread.Join();
                readerThread.Join();
            }
        }
    }

    static void WriteData(PipeStream pipeStream)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(pipeStream))
            {
                writer.AutoFlush = true;
                for (int i = 0; i < 10; i++)
                {
                    writer.WriteLine($"Message {i}");
                    Thread.Sleep(500); // Simulate work
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine($"WriteData IOException: {ex.Message}");
        }
    }

    static void ReadData(PipeStream pipeStream)
    {
        try
        {
            using (StreamReader reader = new StreamReader(pipeStream))
            {
                string message;
                while ((message = reader.ReadLine()) != null)
                {
                    Console.WriteLine($"Received: {message}");
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine($"ReadData IOException: {ex.Message}");
        }
    }
}