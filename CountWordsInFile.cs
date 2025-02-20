using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class CountWordsInFile
{
    static void Main(string[] args)
    {
        string filePath = "source.txt";

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                Dictionary<string, int> wordCount = new Dictionary<string, int>();
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(new char[] { ' ', '\t', '\n', '\r', '.'}, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in words)
                    {
                        string lowerWord = word.ToLower();
                        if (wordCount.ContainsKey(lowerWord))
                        {
                            wordCount[lowerWord]++;
                        }
                        else
                        {
                            wordCount.Add(lowerWord, 1);
                        }
                    }
                }

                var sortedWordCount = wordCount.OrderByDescending(w => w.Value).Take(5);

                Console.WriteLine("Top 5 most frequently occurring words:");
                foreach (var word in sortedWordCount)
                {
                    Console.WriteLine($"{word.Key}: {word.Value}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}