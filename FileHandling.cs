using System;
using System.IO;

class FileHandling
{
    static void Main(string[] args)
    {
        string sourceFilePath = "source.txt";
        string destinationFilePath = "destination.txt";

        try
        {
            // Check if the source file exists
            if (!File.Exists(sourceFilePath))
            {
                Console.WriteLine("Source file does not exist.");
                return;
            }

            // Read from the source file
            using (FileStream sourceStream = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
            using (StreamReader reader = new StreamReader(sourceStream))
            {
                string content = reader.ReadToEnd();

                // Write to the destination file
                using (FileStream destinationStream = new FileStream(destinationFilePath, FileMode.Create, FileAccess.Write))
                using (StreamWriter writer = new StreamWriter(destinationStream))
                {
                    writer.Write(content);
                }
            }

            Console.WriteLine("File has been copied successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}