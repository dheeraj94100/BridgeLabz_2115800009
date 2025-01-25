using System;

class Program
{
    static void Main()
    {
        // Take user input for the number
        Console.Write("Enter a number for the multiplication table: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Array to store multiplication results
        int[] results = new int[4];

        // Calculate the multiplication table for numbers 6 to 9
        for (int i = 0; i < results.Length; i++)
        {
            results[i] = number * (i + 6);
        }

        // Display the multiplication table from 6 to 9
        Console.WriteLine($"Multiplication table for {number} from 6 to 9:");
        for (int i = 0; i < results.Length; i++)
        {
            Console.WriteLine($"{number} * {i + 6} = {results[i]}");
        }
    }
}
