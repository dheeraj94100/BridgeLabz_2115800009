using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        // Path to the binary file
        string filePath = "binaryfile.bin"; // Replace with your file path

        // Check if the file exists
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File does not exist.");
            return;
        }

        // Use FileStream to read the binary data
        using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            // Use StreamReader to convert the byte stream to a character stream
            using (StreamReader reader = new StreamReader(fileStream, Encoding.UTF8))
            {
                // Read and print the characters
                string content = reader.ReadToEnd();
                Console.WriteLine("File content as characters:");
                Console.WriteLine(content);
            }
        }
    }
}