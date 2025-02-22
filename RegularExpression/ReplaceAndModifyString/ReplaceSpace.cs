using System;
using System.Text.RegularExpressions;

namespace ReplaceAndModifyString
{
    class ReplaceSpace
    {
        static void Main(string[] args)
        {
            string input = "This is an example    with multiple spaces.";
            string output = ReplaceMultipleSpacesWithSingleSpace(input);
            Console.WriteLine(output);
        }

        static string ReplaceMultipleSpacesWithSingleSpace(string input)
        {
            return Regex.Replace(input, @"\s+", " ");
        }
    }
}