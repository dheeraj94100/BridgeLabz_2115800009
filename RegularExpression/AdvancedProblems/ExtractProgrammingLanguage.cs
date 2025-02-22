using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class ExtractProgrammingLanguage
{
    static void Main(string[] args)
    {
        string text = "I love Java, Python, and JavaScript, but I haven't tried Go yet.";
        List<string> programmingLanguages = ExtractLanguages(text);

        Console.WriteLine(string.Join(", ", programmingLanguages));
    }

    static List<string> ExtractLanguages(string text)
    {
        List<string> languages = new List<string>();
        string pattern = @"\b(Java|Python|JavaScript|Go)\b";
        MatchCollection matches = Regex.Matches(text, pattern);

        foreach (Match match in matches)
        {
            languages.Add(match.Value);
        }

        return languages;
    }
}