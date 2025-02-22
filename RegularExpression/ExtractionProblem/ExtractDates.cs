using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ExtractionProblem
{
    class ExtractDates
    {
        static void Main(string[] args)
        {
            string text = "The events are scheduled for 12/05/2023, 15/08/2024, and 29/02/2020.";
            List<string> dates = ExtractDatesFromText(text);

            foreach (string date in dates)
            {
                Console.WriteLine(date);
            }
        }

        static List<string> ExtractDatesFromText(string text)
        {
            List<string> dates = new List<string>();
            string pattern = @"\b\d{2}/\d{2}/\d{4}\b";
            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                dates.Add(match.Value);
            }

            return dates;
        }
    }
}