using System;
namespace ConstructorDemo
{
    class Program
    {
        private Program()
        {
            Console.WriteLine("This is private constructor");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Main method");
            Console.ReadKey();
        }
    }
}