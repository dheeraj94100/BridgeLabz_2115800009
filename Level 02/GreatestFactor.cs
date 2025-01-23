using System;

class GreatestFactor
{
    static void Main()
    {
        // Taking input from the user
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Variable to store the greatest factor
        int greatestFactor = 1;

        // Loop from number-1 down to 1
        for (int i = number - 1; i >= 1; i--)
        {
            if (number % i == 0)  // Check if i divides the number perfectly
            {
                greatestFactor = i;
                break;  // Exit loop once we find the greatest factor
            }
        }

        // Display the greatest factor
        Console.WriteLine($"The greatest factor of {number} (besides itself) is {greatestFactor}");
    }
}