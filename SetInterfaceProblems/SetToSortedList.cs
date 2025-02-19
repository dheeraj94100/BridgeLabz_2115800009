using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Enter elements of the Set separated by space: ");
        HashSet<int> set = new HashSet<int>(Console.ReadLine()
                                 .Split(' ')
                                 .Select(x => Convert.ToInt32(x)));

        List<int> sortedList = set.ToList(); // Convert to list
        sortedList.Sort(); // Sort in ascending order

        Console.WriteLine("Sorted List: [" + string.Join(", ", sortedList) + "]");
    }
}
