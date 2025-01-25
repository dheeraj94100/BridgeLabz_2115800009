using System;

class ReverseNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Find the count of digits in the number
        int temp = number;
        int count = 0;
        while (temp != 0)
        {
            temp /= 10;
            count++;
        }

        // Find the digits in the number and save them in an array
        int[] digits = new int[count];
        temp = number;
        for (int i = 0; i < count; i++)
        {
            digits[i] = temp % 10;
            temp /= 10;
        }

        // Create an array to store the elements of the digits array in reverse order
        int[] reversedDigits = new int[count];
        for (int i = 0; i < count; i++)
        {
            reversedDigits[i] = digits[count - 1 - i];
        }

        // Display the elements of the array in reverse order
        Console.Write("Reversed number: ");
        foreach (int digit in reversedDigits)
        {
            Console.Write(digit);
        }
    }
}