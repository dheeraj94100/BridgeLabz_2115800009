using System;

class Program
{
    static void Main()
    {
        // Take user input for the number
        Console.Write("Enter a number for the multiplication table: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Array to store multiplication results
        int[] table = new int[10];

        // Loop to calculate the multiplication table
        for (int i = 0; i < table.Length; i++)
        {
            table[i] = number * (i + 1);
        }

        // Display the multiplication table
        Console.WriteLine($"Multiplication table for {number}:");
        for (int i = 0; i < table.Length; i++)
        {
            Console.WriteLine($"{number} * {i + 1} = {table[i]}");
        }
    }
}
