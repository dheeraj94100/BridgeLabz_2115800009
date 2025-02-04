using System;
namespace ConstructorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CopyConstructor obj1 = new CopyConstructor(10);
            obj1.Display();
            Console.ReadKey();
        }
    }

    public class CopyConstructor
    {
        int x;
        public CopyConstructor(int i)
        {
            x = i;
        }
        public void Display()
        {
            Console.WriteLine($"Value of X = {x}");
        }
    }
}