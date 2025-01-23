using System;

class Armstrong
{
    static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        int temp = num;
        int sum = 0;
        while(temp != 0)
        {
            int rem = temp % 10;
            temp /= 10;
            sum += (int)Math.Pow(rem, 3);
        }
        Console.WriteLine(sum == num ? "Armstrong" : "Not Armstrong");
    }
}