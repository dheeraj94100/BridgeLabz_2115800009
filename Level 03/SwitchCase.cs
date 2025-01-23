using System;

class SwitchCase
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number:");
        double first = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        double second = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter an operator (+, -, *, /):");
        char op = Console.ReadLine()[0];

        double result;

        switch (op)
        {
            case '+':
                result = first + second;
                break;
            case '-':
                result = first - second;
                break;
            case '*':
                result = first * second;
                break;
            case '/':
                if (second != 0)
                {
                    result = first / second;
                }
                else
                {
                    Console.WriteLine("Cannot divide by zero.");
                    return;
                }
                break;
            default:
                Console.WriteLine("Invalid operator.");
                return;
        }

        Console.WriteLine("Result: " + result);
    }
}