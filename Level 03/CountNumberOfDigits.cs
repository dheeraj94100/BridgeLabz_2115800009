using System;

class CountNumberOfDigits
{
    static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        while(num != 0)
        {
            num /= 10;
            count++;
        }
        Console.WriteLine(count);
    }
}