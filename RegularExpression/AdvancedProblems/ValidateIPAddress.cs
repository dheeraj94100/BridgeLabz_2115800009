using System;
using System.Text.RegularExpressions;

namespace AdvancedProblems
{
    public class ValidateIPAddress
    {
        public static bool IsValidIPv4(string ipAddress)
        {
            if (string.IsNullOrWhiteSpace(ipAddress))
                return false;

            string pattern = @"^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(ipAddress);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(IsValidIPv4("192.168.1.1")); // True
            Console.WriteLine(IsValidIPv4("255.255.255.255")); // True
            Console.WriteLine(IsValidIPv4("256.256.256.256")); // False
            Console.WriteLine(IsValidIPv4("192.168.1")); // False
        }
    }
}