using System;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    public class ValidateUsername
    {
        public static bool IsValidUsername(string username)
        {
            // Regular expression to match the criteria
            string pattern = @"^[a-zA-Z][a-zA-Z0-9_]{4,14}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(username);
        }

        public static void Main(string[] args)
        {
            string[] testUsernames = { "user_123", "123user", "us", "valid_user", "user12345" };

            foreach (string username in testUsernames)
            {
                Console.WriteLine($"{username} → {(IsValidUsername(username) ? "Valid" : "Invalid")}");
            }
        }
    }
}