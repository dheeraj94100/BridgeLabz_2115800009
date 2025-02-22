using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ReplaceAndModifyString
{
    class CensorBad
    {
        static void Main(string[] args)
        {
            string input = "This is a damn bad example with some stupid words.";
            List<string> badWords = new List<string> { "damn", "stupid" };
            string censoredSentence = CensorBadWords(input, badWords);
            Console.WriteLine(censoredSentence);
        }

        static string CensorBadWords(string sentence, List<string> badWords)
        {
            foreach (var badWord in badWords)
            {
                string pattern = @"\b" + Regex.Escape(badWord) + @"\b";
                sentence = Regex.Replace(sentence, pattern, "****", RegexOptions.IgnoreCase);
            }
            return sentence;
        }
    }
}