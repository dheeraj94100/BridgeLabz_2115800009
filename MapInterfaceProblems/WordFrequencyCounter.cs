using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class WordFrequencyCounter
{
    static void Main()
    {
        
        string filePath = "a.txt";

        // Check if the file exists before proceeding
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found. Please provide a valid file path.");
            return;
        }

        string text = File.ReadAllText(filePath); // Read the entire file content
        Dictionary<string, int> wordCount = CountWordFrequency(text);

        Console.WriteLine("\nWord Frequency:");
        foreach (var pair in wordCount)
        {
            Console.WriteLine($"\"{pair.Key}\": {pair.Value}");
        }
    }

    static Dictionary<string, int> CountWordFrequency(string text)
    {
        Dictionary<string, int> frequency = new Dictionary<string, int>();

        // Normalize text: Convert to lowercase and split using regex to handle punctuation
        string[] words = Regex.Split(text.ToLower(), @"\W+");

        foreach (string word in words)
        {
            if (!string.IsNullOrEmpty(word))  // Ignore empty strings
            {
                if (frequency.ContainsKey(word))
                    frequency[word]++;
                else
                    frequency[word] = 1;
            }
        }

        return frequency;
    }
}
