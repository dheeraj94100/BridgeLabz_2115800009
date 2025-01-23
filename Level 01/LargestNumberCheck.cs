using System;

class LargestNumberCheck
{
    static void Main(string[] args)
    {
        // Taking input from the user
        Console.Write("Enter the first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int number3 = Convert.ToInt32(Console.ReadLine());

        // Checking if the first number is the largest
        if (number1 > number2 && number1 > number3)
        {
            Console.WriteLine("Is the first number the largest? Yes");
        }
        else
        {
            Console.WriteLine("Is the first number the largest? No");
        }

        // Checking if the second number is the largest
        if (number2 > number1 && number2 > number3)
        {
            Console.WriteLine("Is the second number the largest? Yes");
        }
        else
        {
            Console.WriteLine("Is the second number the largest? No");
        }

        // Checking if the third number is the largest
        if (number3 > number1 && number3 > number2)
        {
            Console.WriteLine("Is the third number the largest? Yes");
        }
        else
        {
            Console.WriteLine("Is the third number the largest? No");
        }
    }
}

