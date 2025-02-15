using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Path to the text file
        string filePath = "a.txt"; // Replace with your file path

        // Word to search for
        Console.Write("Enter the word to search for: ");
        string word = Console.ReadLine();

        // Check if the file exists
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File does not exist.");
            return;
        }

        // Initialize word count
        int wordCount = 0;

        // Use StreamReader to read the file line by line
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;

            // Read each line and count occurrences of the word
            while ((line = reader.ReadLine()) != null)
            {
                // Split the line into words and count matches
                string[] words = line.Split(new[] { ' ', '.', ',', '!', '?', ';', ':', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string w in words)
                {
                    if (w.Equals(word, StringComparison.OrdinalIgnoreCase)) // Case-insensitive comparison
                    {
                        wordCount++;
                    }
                }
            }
        }

        // Print the result
        Console.WriteLine($"The word '{word}' appears {wordCount} times in the file.");
    }
}