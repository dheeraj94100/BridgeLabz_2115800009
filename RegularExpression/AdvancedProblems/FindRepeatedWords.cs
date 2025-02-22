using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdvancedProblems
{
    class FindRepeatedWords
    {
        static void Main(string[] args)
        {
            string input = "This is is a repeated repeated word test.";
            var repeatedWords = FindRepeatingWords(input);
            Console.WriteLine(string.Join(", ", repeatedWords));
        }

        static IEnumerable<string> FindRepeatingWords(string input)
        {
            var wordPattern = new Regex(@"\b(\w+)\b", RegexOptions.IgnoreCase);
            var matches = wordPattern.Matches(input);
            var wordCount = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            foreach (Match match in matches)
            {
                string word = match.Value;
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }

            return wordCount.Where(kvp => kvp.Value > 1).Select(kvp => kvp.Key);
        }
    }
}