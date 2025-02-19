using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Enter elements of Subset Set separated by space: ");
        HashSet<int> subset = new HashSet<int>(Console.ReadLine()
                                     .Split(' ')
                                     .Select(x => Convert.ToInt32(x)));

        Console.Write("Enter elements of Main Set separated by space: ");
        HashSet<int> mainSet = new HashSet<int>(Console.ReadLine()
                                      .Split(' ')
                                      .Select(x => Convert.ToInt32(x)));

        bool isSubset = subset.IsSubsetOf(mainSet);

        Console.WriteLine("Is Subset: " + isSubset);
    }
}
