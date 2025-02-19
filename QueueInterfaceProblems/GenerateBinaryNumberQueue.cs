using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter the value of N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        List<string> binaryNumbers = GenerateBinaryNumbers(N);

        Console.WriteLine("Binary Numbers: {" + string.Join(", ", binaryNumbers) + "}");
    }

    static List<string> GenerateBinaryNumbers(int N)
    {
        List<string> result = new List<string>();
        Queue<string> queue = new Queue<string>();

        queue.Enqueue("1");

        for (int i = 0; i < N; i++)
        {
            string binary = queue.Dequeue();
            result.Add(binary);

            queue.Enqueue(binary + "0");
            queue.Enqueue(binary + "1");
        }

        return result;
    }
}
