using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class ExtractLink
{
    static void Main(string[] args)
    {
        string inputText = "Visit https://www.google.com and http://example.org for more info.";
        List<string> links = ExtractLinks(inputText);

        foreach (string link in links)
        {
            Console.WriteLine(link);
        }
    }

    static List<string> ExtractLinks(string text)
    {
        List<string> links = new List<string>();
        string pattern = @"http[s]?://[^\s]+";
        Regex regex = new Regex(pattern);

        MatchCollection matches = regex.Matches(text);
        foreach (Match match in matches)
        {
            links.Add(match.Value);
        }

        return links;
    }
}