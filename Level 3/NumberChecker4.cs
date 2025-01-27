using System;

public class NumberChecker
{
    public static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

    public static bool IsNeon(int number)
    {
        int square = number * number;
        int sumOfDigits = 0;
        while (square > 0)
        {
            sumOfDigits += square % 10;
            square /= 10;
        }
        return sumOfDigits == number;
    }

    public static bool IsSpy(int number)
    {
        int sumOfDigits = 0;
        int productOfDigits = 1;
        while (number > 0)
        {
            int digit = number % 10;
            sumOfDigits += digit;
            productOfDigits *= digit;
            number /= 10;
        }
        return sumOfDigits == productOfDigits;
    }

    public static bool IsAutomorphic(int number)
    {
        int square = number * number;
        while (number > 0)
        {
            if ((number % 10) != (square % 10)) return false;
            number /= 10;
            square /= 10;
        }
        return true;
    }

    public static bool IsBuzz(int number)
    {
        return (number % 7 == 0) || (number % 10 == 7);
    }

    public static void Main(string[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Number: {number}");
        Console.WriteLine($"Is Prime: {IsPrime(number)}");
        Console.WriteLine($"Is Neon: {IsNeon(number)}");
        Console.WriteLine($"Is Spy: {IsSpy(number)}");
        Console.WriteLine($"Is Automorphic: {IsAutomorphic(number)}");
        Console.WriteLine($"Is Buzz: {IsBuzz(number)}");
    }
}