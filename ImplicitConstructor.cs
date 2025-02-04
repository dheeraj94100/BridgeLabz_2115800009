using System;
namespace ConstructorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Test obj = new Test();
            Console.WriteLine($"i = {obj.i}");
            Console.WriteLine($"b = {obj.b}");

            //value null will be printed, so here we checking the null
            if (obj.s == null)
            {
                Console.WriteLine("s = null");
            }

            Console.ReadKey();
        }
    }
    class Test
    {
        public int i;
        public bool b;
        public string s;
    }
}