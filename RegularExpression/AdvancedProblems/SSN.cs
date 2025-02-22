using System;
using System.Text.RegularExpressions;

class SSNValidator
{
    static void Main(string[] args)
    {
        string input = "My SSN is 123-45-6789.";
        string pattern = @"\b\d{3}-\d{2}-\d{4}\b";

        Match match = Regex.Match(input, pattern);

        if (match.Success)
        {
            Console.WriteLine("✅ \"{match.Value}\" is valid");
        }
        else
        {
            Console.WriteLine("❌ \"{input}\" does not contain a valid SSN");
        }
    }
}