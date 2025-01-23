
using System;

class MultiplicationTable
{
    static void Main(string[] args)
    {
        // Taking user input for the number
        Console.Write("Enter a number to find its multiplication table from 6 to 9: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Using a for loop to generate the multiplication table from 6 to 9
        for (int i = 6; i <= 9; i++)
        {
            int result = number * i;
            Console.WriteLine($"{number} * {i} = {result}");
        }
    }
}

