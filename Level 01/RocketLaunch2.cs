using System;

class RocketLaunchCountdown
{
    static void Main(string[] args)
    {
        // Taking user input for the countdown start number
        Console.Write("Enter the countdown start number: ");
        int counter = Convert.ToInt32(Console.ReadLine());

        // Checking if the input is greater than or equal to 1
        if (counter >= 1)
        {
            // Countdown using a for loop
            for (int i = counter; i >= 1; i--)
            {
                Console.WriteLine(i); // Print the current value of the counter
            }
            Console.WriteLine("Launch!");
        }
        else
        {
            Console.WriteLine("Please enter a valid positive number.");
        }
    }
}