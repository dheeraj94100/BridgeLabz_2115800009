using System;
using System.Reflection;

public class MathOperations
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter method name (Add, Subtract, Multiply):");
            string methodName = Console.ReadLine();

            Console.WriteLine("Enter first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int num2 = int.Parse(Console.ReadLine());

            MathOperations mathOperations = new MathOperations();
            MethodInfo method = typeof(MathOperations).GetMethod(methodName);

            if (method == null)
            {
                throw new ArgumentException("Method not found");
            }

            object result = method.Invoke(mathOperations, new object[] { num1, num2 });
            Console.WriteLine($"Result: {result}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Input format is incorrect. Please enter valid numbers.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (TargetInvocationException ex)
        {
            Console.WriteLine("An error occurred while invoking the method.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }
}