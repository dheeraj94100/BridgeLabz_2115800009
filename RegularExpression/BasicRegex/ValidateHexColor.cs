using System;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    public class ValidateHexColor
    {
        public static bool IsValidHexColor(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            string pattern = @"^#([0-9A-Fa-f]{6})$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(input);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(IsValidHexColor("#AABBCC")); // True
            Console.WriteLine(IsValidHexColor("#123456")); // True
            Console.WriteLine(IsValidHexColor("#GHIJKL")); // False
            Console.WriteLine(IsValidHexColor("123456"));  // False
        }
    }
}