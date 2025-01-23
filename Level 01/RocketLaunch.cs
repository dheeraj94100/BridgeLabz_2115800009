
using System;

class RocketLaunchCountdown
{
    static void Main(string[] args)
    {
        // Taking user input for the countdown start value
        Console.Write("Enter the countdown start number: ");
        int counter = Convert.ToInt32(Console.ReadLine());

        // Checking if the input is greater than or equal to 1
        if (counter >= 1)
        {
            // Countdown using a while loop
            while (counter >= 1)
            {
                Console.WriteLine(counter); // Print the current value of the counter
                counter--; // Decrement the counter
            }
            Console.WriteLine("Launch!");
        }
        else
        {
            Console.WriteLine("Please enter a valid positive number.");
        }
    }
}

