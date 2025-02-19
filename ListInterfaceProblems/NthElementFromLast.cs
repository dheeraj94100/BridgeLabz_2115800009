using System;
using System.Collections.Generic;

class Program
{
    static string FindNthFromEnd(LinkedList<string> list, int n)
    {
        LinkedListNode<string> first = list.First;
        LinkedListNode<string> second = list.First;

        // Move 'first' pointer n steps ahead
        for (int i = 0; i < n; i++)
        {
            if (first == null)
            {
                Console.WriteLine("N is larger than the list size.");
                return null;
            }
            first = first.Next;
        }

        // Move both pointers until 'first' reaches the end
        while (first != null)
        {
            first = first.Next;
            second = second.Next;
        }

        return second.Value;
    }

    static void Main()
    {
        Console.Write("Enter the list elements separated by space: ");
        string[] elements = Console.ReadLine().Split(' ');

        LinkedList<string> linkedList = new LinkedList<string>(elements);

        Console.Write("Enter the position (N) from the end: ");
        int n = Convert.ToInt32(Console.ReadLine());

        string nthElement = FindNthFromEnd(linkedList, n);

        if (nthElement != null)
        {
            Console.WriteLine($"The {n}th element from the end is: {nthElement}");
        }
    }
}
