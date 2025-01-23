using System;

class Harshad
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
            sum += rem;
        }
        Console.WriteLine(num % sum == 0 ? "Harshad" : "Not Harshad");
    }
}