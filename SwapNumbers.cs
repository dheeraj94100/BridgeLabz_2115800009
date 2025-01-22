using System;

class SwapNumbers
{
    static void Main(string[] args)
    {
        // Input: Taking two numbers from the user
        Console.Write("Enter the first number (number1): ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number (number2): ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        // Swapping the numbers
        int temp = number1;
        number1 = number2;
        number2 = temp;

        // Output: Display the swapped numbers
        Console.WriteLine($"The swapped numbers are {number1} and {number2}.");
    }
}
