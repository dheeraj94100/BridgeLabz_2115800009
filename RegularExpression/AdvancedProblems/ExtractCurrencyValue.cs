using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class ExtractCurrencyValue
{
    static void Main(string[] args)
    {
        string text = "The price is $45.99, and the discount is $ 10.50.";
        List<string> currencyValues = ExtractCurrencyValues(text);

        foreach (string value in currencyValues)
        {
            Console.WriteLine(value);
        }
    }

    static List<string> ExtractCurrencyValues(string text)
    {
        List<string> values = new List<string>();
        string pattern = @"\$\s?\d+(\.\d{2})?";
        MatchCollection matches = Regex.Matches(text, pattern);

        foreach (Match match in matches)
        {
            string value = match.Value.Replace("$", "").Trim();
            values.Add(value);
        }

        return values;
    }
}