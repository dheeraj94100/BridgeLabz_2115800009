using System;
namespace ConstructorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ExplicitConstructor obj1 = new ExplicitConstructor();
            ExplicitConstructor obj2 = new ExplicitConstructor();
            ExplicitConstructor obj3 = new ExplicitConstructor();
            ExplicitConstructor obj4 = new ExplicitConstructor();

            Console.ReadKey();
        }
    }
    class ExplicitConstructor
    {
        public ExplicitConstructor()
        {
            Console.WriteLine("Explicit Constructor is Called!");
        }
    }
}