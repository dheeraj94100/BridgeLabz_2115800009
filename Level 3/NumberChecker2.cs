using System;

public class NumberChecker
{
    public static void Main(string[] args)
    {
        int number = 21;
        int[] digits = GetDigits(number);

        Console.WriteLine("Count of digits: " + GetDigitCount(number));
        Console.WriteLine("Sum of digits: " + GetSumOfDigits(digits));
        Console.WriteLine("Sum of squares of digits: " + GetSumOfSquaresOfDigits(digits));
        Console.WriteLine("Is Harshad number: " + IsHarshadNumber(number, digits));
        
        int[,] frequency = GetDigitFrequency(digits);
        Console.WriteLine("Digit Frequency:");
        for (int i = 0; i < frequency.GetLength(0); i++)
        {
            Console.WriteLine($"Digit {frequency[i, 0]}: {frequency[i, 1]} times");
        }
    }

    public static int GetDigitCount(int number)
    {
        int count = 0;
        while (number != 0)
        {
            number /= 10;
            count++;
        }
        return count;
    }

    public static int[] GetDigits(int number)
    {
        string numberStr = number.ToString();
        int[] digits = new int[numberStr.Length];
        for (int i = 0; i < numberStr.Length; i++)
        {
            digits[i] = int.Parse(numberStr[i].ToString());
        }
        return digits;
    }

    public static int GetSumOfDigits(int[] digits)
    {
        int sum = 0;
        foreach (int digit in digits)
        {
            sum += digit;
        }
        return sum;
    }

    public static int GetSumOfSquaresOfDigits(int[] digits)
    {
        int sum = 0;
        foreach (int digit in digits)
        {
            sum += (int)Math.Pow(digit, 2);
        }
        return sum;
    }

    public static bool IsHarshadNumber(int number, int[] digits)
    {
        int sumOfDigits = GetSumOfDigits(digits);
        return number % sumOfDigits == 0;
    }

    public static int[,] GetDigitFrequency(int[] digits)
    {
        int[,] frequency = new int[10, 2];
        for (int i = 0; i < 10; i++)
        {
            frequency[i, 0] = i;
            frequency[i, 1] = 0;
        }

        foreach (int digit in digits)
        {
            frequency[digit, 1]++;
        }

        return frequency;
    }
}