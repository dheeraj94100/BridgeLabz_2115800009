using System;

class SwapNumbers
{
    static void Main(string[] args)
    {
        // Prompt user to enter two numbers
        Console.WriteLine("Enter two numbers:");
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());

        // Swap the numbers using tuple
        (number1, number2) = (number2, number1);

        // Display the swapped numbers
        Console.WriteLine($"The swapped numbers are {number1} and {number2}");
    }
}
