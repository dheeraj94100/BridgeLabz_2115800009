using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class ExtractAllEmailAddress
{
    static void Main(string[] args)
    {
        string text = "Contact us at support@example.com and info@company.org";
        List<string> emailAddresses = ExtractEmailAddresses(text);

        foreach (string email in emailAddresses)
        {
            Console.WriteLine(email);
        }
    }

    static List<string> ExtractEmailAddresses(string text)
    {
        List<string> emailAddresses = new List<string>();
        string pattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";

        MatchCollection matches = Regex.Matches(text, pattern);
        foreach (Match match in matches)
        {
            emailAddresses.Add(match.Value);
        }

        return emailAddresses;
    }
}