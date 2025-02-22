using System;
using System.Text.RegularExpressions;

namespace AdvancedProblems
{
    public class ValidateCreditCard
    {
        public static bool IsValidCreditCard(string cardNumber)
        {
            // Visa: Starts with 4 and has 16 digits
            string visaPattern = @"^4\d{15}$";
            // MasterCard: Starts with 5 and has 16 digits
            string masterCardPattern = @"^5\d{15}$";

            if (Regex.IsMatch(cardNumber, visaPattern))
            {
                return true;
            }
            else if (Regex.IsMatch(cardNumber, masterCardPattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter credit card number:");
            string cardNumber = Console.ReadLine();

            if (IsValidCreditCard(cardNumber))
            {
                Console.WriteLine("The credit card number is valid.");
            }
            else
            {
                Console.WriteLine("The credit card number is invalid.");
            }
        }
    }
}