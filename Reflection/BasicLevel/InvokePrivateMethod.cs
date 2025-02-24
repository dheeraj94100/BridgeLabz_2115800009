using System;
using System.Reflection;

public class Calculator
{
    private int Multiply(int a, int b)
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
            Calculator calculator = new Calculator();
            Type type = typeof(Calculator);
            MethodInfo methodInfo = type.GetMethod("Multiply", BindingFlags.NonPublic | BindingFlags.Instance);

            if (methodInfo != null)
            {
                object result = methodInfo.Invoke(calculator, new object[] { 5, 3 });
                Console.WriteLine("Result of Multiply: " + result);
            }
            else
            {
                Console.WriteLine("Method not found.");
            }
        }
        catch (TargetInvocationException ex)
        {
            Console.WriteLine("An error occurred while invoking the method: " + ex.InnerException?.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}