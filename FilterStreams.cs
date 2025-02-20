using System;
using System.IO;
using System.Text;

class FilterStreams
{
    static void Main(string[] args)
    {
        string inputFilePath = "input.txt";
        string outputFilePath = "output.txt";

        try
        {
            using (FileStream inputFileStream = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
            using (BufferedStream bufferedInputStream = new BufferedStream(inputFileStream))
            using (StreamReader reader = new StreamReader(bufferedInputStream, Encoding.UTF8))
            using (FileStream outputFileStream = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
            using (BufferedStream bufferedOutputStream = new BufferedStream(outputFileStream))
            using (StreamWriter writer = new StreamWriter(bufferedOutputStream, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine(line.ToLower());
                }
            }

            Console.WriteLine("File processing completed successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}