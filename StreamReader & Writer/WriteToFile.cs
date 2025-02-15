using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Path to the output file
        string filePath = "output.txt"; // Replace with your desired file path

        // Prompt the user to enter text
        Console.WriteLine("Enter text to write to the file (type 'exit' to finish):");

        // Use StreamWriter to write to the file
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            string input;
            while (true)
            {
                // Read user input
                input = Console.ReadLine();

                // Exit condition
                if (input.ToLower() == "exit")
                {
                    break;
                }

                // Write the input to the file
                writer.WriteLine(input);
            }
        }

        Console.WriteLine("Text has been written to the file.");
    }
}