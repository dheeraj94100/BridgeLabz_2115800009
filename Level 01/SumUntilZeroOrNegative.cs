
using System;

class SumUntilZeroOrNegative
{
    static void Main(string[] args)
    {
        // Initialize total to 0.0
        double total = 0.0;
        double userInput;

        // Infinite while loop
        while (true)
        {
            // Ask the user to input a number
            Console.Write("Enter a number (0 or negative number to stop): ");
            userInput = Convert.ToDouble(Console.ReadLine());

            // Check if the user entered 0 or a negative number to stop
            if (userInput <= 0)
            {
                break; // Exit the loop if the input is 0 or negative
            }

            // Add the number to the total
            total += userInput;
        }

        // Display the total
        Console.WriteLine($"The total sum of the numbers entered is: {total}");
    }
}

