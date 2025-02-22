using System;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    class ValidateLicensePlate
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the license plate:");
            string licensePlate = Console.ReadLine();

            if (IsValidLicensePlate(licensePlate))
            {
                Console.WriteLine("The license plate is valid.");
            }
            else
            {
                Console.WriteLine("The license plate is invalid.");
            }
        }

        static bool IsValidLicensePlate(string licensePlate)
        {
            string pattern = @"^[A-Z]{2}\d{4}$";
            return Regex.IsMatch(licensePlate, pattern);
        }
    }
}