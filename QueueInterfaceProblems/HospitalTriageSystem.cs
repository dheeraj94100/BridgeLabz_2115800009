using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        PriorityQueue<string, int> triageQueue = new PriorityQueue<string, int>(Comparer<int>.Create((a, b) => b.CompareTo(a))); // Max-Heap

        Console.Write("Enter the number of patients: ");
        int numPatients = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < numPatients; i++)
        {
            Console.Write("Enter patient name: ");
            string name = Console.ReadLine();

            Console.Write("Enter severity level (higher number = higher priority): ");
            int severity = Convert.ToInt32(Console.ReadLine());

            triageQueue.Enqueue(name, severity);
        }

        Console.WriteLine("\nTreatment Order:");
        while (triageQueue.Count > 0)
        {
            Console.WriteLine(triageQueue.Dequeue());
        }
    }
}
