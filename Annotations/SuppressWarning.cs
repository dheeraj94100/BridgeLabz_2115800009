using System;
using System.Collections;  // Using non-generic ArrayList

class Program
{
    static void Main(string[] args)
    {
        #pragma warning disable CS8600 // Disables warnings for potential null assignments
        #pragma warning disable CS8602 // Disables warnings for possible null dereference
        
        ArrayList list = new ArrayList();  // Using non-generic collection (discouraged in modern C#)
        list.Add(10);
        list.Add("Hello");
        list.Add(3.14);

        #pragma warning restore CS8600 // Re-enables the warnings
        #pragma warning restore CS8602 

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}
