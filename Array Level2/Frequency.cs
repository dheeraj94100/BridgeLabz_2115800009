using System;

class Frequency
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        
        int[] frequency = new int[10];

        foreach (char digit in input)
        {
            if (char.IsDigit(digit))
            {
                int digitValue = digit - '0';
                frequency[digitValue]++;
            }
        }

        Console.WriteLine("Digit Frequency:");
        for (int i = 0; i < frequency.Length; i++)
        {
            if (frequency[i] > 0)
            {
                Console.WriteLine($"Digit {i}: {frequency[i]} times");
            }
        }
    }
}