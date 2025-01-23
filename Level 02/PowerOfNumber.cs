using System;

class PowerOfNumber
{
    static void Main()
    {
        // Taking input for number and power
        Console.Write("Enter the number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the power: ");
        int power = Convert.ToInt32(Console.ReadLine());

        // Variable to store the result
        int result = 1;

        // Loop to calculate the power of the number
        for (int i = 1; i <= power; i++)
        {
            result *= number;
        }

        // Display the result
        Console.WriteLine($"{number} raised to the power {power} is {result}");
    }
}