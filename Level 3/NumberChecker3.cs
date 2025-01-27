using System;

public class NumberChecker
{
    public static int CountDigits(int number)
    {
        int count = 0;
        while (number != 0)
        {
            number /= 10;
            count++;
        }
        return count;
    }

    public static int[] StoreDigits(int number)
    {
        string numberStr = number.ToString();
        int[] digits = new int[numberStr.Length];
        for (int i = 0; i < numberStr.Length; i++)
        {
            digits[i] = int.Parse(numberStr[i].ToString());
        }
        return digits;
    }

    public static int[] ReverseDigitsArray(int[] digits)
    {
        Array.Reverse(digits);
        return digits;
    }

    public static bool CompareArrays(int[] array1, int[] array2)
    {
        if (array1.Length != array2.Length)
        {
            return false;
        }
        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i] != array2[i])
            {
                return false;
            }
        }
        return true;
    }

    public static bool IsPalindrome(int number)
    {
        int[] digits = StoreDigits(number);
        int[] reversedDigits = ReverseDigitsArray((int[])digits.Clone());
        return CompareArrays(digits, reversedDigits);
    }

    public static bool IsDuckNumber(int number)
    {
        int[] digits = StoreDigits(number);
        foreach (int digit in digits)
        {
            if (digit != 0)
            {
                return true;
            }
        }
        return false;
    }

    public static void Main(string[] args)
    {
        int number = 12321;

        Console.WriteLine("Count of digits: " + CountDigits(number));

        int[] digits = StoreDigits(number);
        Console.WriteLine("Digits array: " + string.Join(", ", digits));

        int[] reversedDigits = ReverseDigitsArray((int[])digits.Clone());
        Console.WriteLine("Reversed digits array: " + string.Join(", ", reversedDigits));

        Console.WriteLine("Arrays are equal: " + CompareArrays(digits, reversedDigits));

        Console.WriteLine("Is palindrome: " + IsPalindrome(number));

        Console.WriteLine("Is duck number: " + IsDuckNumber(number));
    }
}