using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ExtractionProblem
{
    class ExtractAllCapitalizedWordsSentence
    {
        static void Main(string[] args)
        {
            string input = "The Eiffel Tower is in Paris and the Statue of Liberty is in New York.";
            List<string> capitalizedWords = ExtractCapitalizedWords(input);
            Console.WriteLine(string.Join(", ", capitalizedWords));
        }

        static List<string> ExtractCapitalizedWords(string input)
        {
            List<string> capitalizedWords = new List<string>();
            string pattern = @"\b[A-Z][a-z]*\b";
            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                capitalizedWords.Add(match.Value);
            }

            return capitalizedWords;
        }
    }
}