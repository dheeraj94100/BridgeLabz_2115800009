using System;

class AbundantNumber
{
    static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for(int i = 1; i <= num / 2; i++)
        {
            if(num % i == 0)
            {
                sum += i;
            }
        }
        Console.WriteLine(sum > num ? "Abundant" : "Not Abundant");
    }
}