using System;
namespace ConstructorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ParameterizedConstructor obj = new ParameterizedConstructor(10);
            Console.ReadKey();
        }
    }

    public class ParameterizedConstructor
    {
        public ParameterizedConstructor(int i)
        {
            Console.WriteLine($"Parameterized Constructor is Called: {i}");
        }
    }
}