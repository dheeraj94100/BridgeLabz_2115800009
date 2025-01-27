using System;

public class NumberChecker
{
    public static void Main(string[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine()); 

        Console.WriteLine($"Count of digits: {CountDigits(number)}");
        int[] digits = GetDigitsArray(number);
        Console.WriteLine($"Digits array: {string.Join(", ", digits)}");
        Console.WriteLine($"Is Duck Number: {IsDuckNumber(digits)}");
        Console.WriteLine($"Is Armstrong Number: {IsArmstrongNumber(number, digits)}");
        FindLargestElements(digits);
        FindSmallestElements(digits);
    }

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

    public static int[] GetDigitsArray(int number)
    {
        string numberStr = number.ToString();
        int[] digits = new int[numberStr.Length];
        for (int i = 0; i < numberStr.Length; i++)
        {
            digits[i] = int.Parse(numberStr[i].ToString());
        }
        return digits;
    }

    public static bool IsDuckNumber(int[] digits)
    {
        foreach (int digit in digits)
        {
            if (digit == 0)
            {
                return true;
            }
        }
        return false;
    }

    public static bool IsArmstrongNumber(int number, int[] digits)
    {
        int sum = 0;
        int power = CountDigits(number);
        foreach (int digit in digits)
        {
            sum += (int)Math.Pow(digit, power);
        }
        return sum == number;
    }

    public static void FindLargestElements(int[] digits)
    {
        int largest = Int32.MinValue;
        int secondLargest = Int32.MinValue;

        foreach (int digit in digits)
        {
            if (digit > largest)
            {
                secondLargest = largest;
                largest = digit;
            }
            else if (digit > secondLargest && digit != largest)
            {
                secondLargest = digit;
            }
        }
        Console.WriteLine($"Largest element: {largest}, Second largest element: {secondLargest}");
    }

    public static void FindSmallestElements(int[] digits)
    {
        int smallest = Int32.MaxValue;
        int secondSmallest = Int32.MaxValue;

        foreach (int digit in digits)
        {
            if (digit < smallest)
            {
                secondSmallest = smallest;
                smallest = digit;
            }
            else if (digit < secondSmallest && digit != smallest)
            {
                secondSmallest = digit;
            }
        }
        Console.WriteLine($"Smallest element: {smallest}, Second smallest element: {secondSmallest}");
    }
}