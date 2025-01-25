using System;
class LargestAndSecondLargest
{
    static void Main()
    {
        int[] digits = new int[10];
        int index = 0;
        int maxDigit = 10;

        Console.WriteLine("Enter digits (enter -1 to stop):");

        while (true)
        {
            int digit = int.Parse(Console.ReadLine());

            if (digit == -1)
                break;

            if (index == maxDigit)
            {
                maxDigit += 10;
                int[] temp = new int[maxDigit];
                Array.Copy(digits, temp, digits.Length);
                digits = temp;
            }

            digits[index++] = digit;
        }

        if (index == 0)
        {
            Console.WriteLine("No digits entered.");
            return;
        }

        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        for (int i = 0; i < index; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] != largest)
            {
                secondLargest = digits[i];
            }
        }

        Console.WriteLine("Largest: " + largest);
        Console.WriteLine("Second Largest: " + secondLargest);
    }
}