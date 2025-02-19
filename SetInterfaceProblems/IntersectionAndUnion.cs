using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Taking input for Set1
        Console.Write("Enter elements of Set1 separated by space: ");
        HashSet<int> set1 = new HashSet<int>(Console.ReadLine()
                                   .Split(' ')
                                   .Select(x => Convert.ToInt32(x)));

        // Taking input for Set2
        Console.Write("Enter elements of Set2 separated by space: ");
        HashSet<int> set2 = new HashSet<int>(Console.ReadLine()
                                   .Split(' ')
                                   .Select(x => Convert.ToInt32(x)));

        // Computing Union
        HashSet<int> unionSet = new HashSet<int>(set1);
        unionSet.UnionWith(set2); // Adds all elements from set2 into set1

        // Computing Intersection
        HashSet<int> intersectionSet = new HashSet<int>(set1);
        intersectionSet.IntersectWith(set2); // Keeps only elements that exist in both sets

        // Displaying the results
        Console.WriteLine("Union: {" + string.Join(", ", unionSet) + "}");
        Console.WriteLine("Intersection: {" + string.Join(", ", intersectionSet) + "}");
    }
}
