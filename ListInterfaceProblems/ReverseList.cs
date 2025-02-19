using System;
using System.Collections; // For ArrayList
using System.Collections.Generic; // For LinkedList<T>

class Program
{
    static void Main()
    {
        // Example with ArrayList
        ArrayList arrayList = new ArrayList() { 1, 2, 3, 4, 5 };
        Console.WriteLine("Original ArrayList: " + string.Join(", ", arrayList.ToArray()));
        ReverseArrayList(arrayList);
        Console.WriteLine("Reversed ArrayList: " + string.Join(", ", arrayList.ToArray()));

        // Example with LinkedList
        LinkedList<int> linkedList = new LinkedList<int>(new int[] { 1, 2, 3, 4, 5 });
        Console.WriteLine("Original LinkedList: " + string.Join(", ", linkedList));
        linkedList = ReverseLinkedList(linkedList);
        Console.WriteLine("Reversed LinkedList: " + string.Join(", ", linkedList));
    }

    // Method to reverse an ArrayList
    static void ReverseArrayList(ArrayList list)
    {
        int start = 0;
        int end = list.Count - 1;

        while (start < end)
        {
            // Swap elements
            object temp = list[start];
            list[start] = list[end];
            list[end] = temp;

            start++;
            end--;
        }
    }

    // Method to reverse a LinkedList
    static LinkedList<int> ReverseLinkedList(LinkedList<int> list)
    {
        LinkedList<int> reversedList = new LinkedList<int>();
        foreach (var item in list)
        {
            reversedList.AddFirst(item);
        }
        return reversedList;
    }
}