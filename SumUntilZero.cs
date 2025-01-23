
using System;

class SumUntilZero
{
    static void Main(string[] args)
    {
        // Initialize total to 0.0
        double total = 0.0;
        double userInput;

        // Use a while loop to get numbers from the user until they enter 0
        do
        {
            // Ask the user to input a number
            Console.Write("Enter a number (0 to stop): ");
            userInput = Convert.ToDouble(Console.ReadLine());

            // Add the number to the total if it is not 0
            if (userInput != 0)
            {
                total += userInput;
            }

        } while (userInput != 0); // Loop continues until the user enters 0

        // Display the total
        Console.WriteLine($"The total sum of the numbers entered is: {total}");
    }
}

