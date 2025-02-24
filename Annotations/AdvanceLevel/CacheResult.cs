using System;
using System.Collections.Generic;
using System.Reflection;

// Define the CacheResult attribute
[AttributeUsage(AttributeTargets.Method)]
class CacheResultAttribute : Attribute { }

class ExpensiveOperations
{
    private static readonly Dictionary<string, object> cache = new Dictionary<string, object>();

    [CacheResult]
    public int ComputeFactorial(int n)
    {
        string cacheKey = $"{nameof(ComputeFactorial)}({n})";

        if (cache.ContainsKey(cacheKey))
        {
            Console.WriteLine($"Returning cached result for {n}!");
            return (int)cache[cacheKey];
        }

        Console.WriteLine($"Computing factorial for {n}...");
        int result = 1;
        for (int i = 2; i <= n; i++)
            result *= i;

        cache[cacheKey] = result; // Store result in cache
        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        ExpensiveOperations operations = new ExpensiveOperations();

        Console.WriteLine(operations.ComputeFactorial(5)); // Computes and stores
        Console.WriteLine(operations.ComputeFactorial(5)); // Retrieves from cache
        Console.WriteLine(operations.ComputeFactorial(6)); // Computes and stores
        Console.WriteLine(operations.ComputeFactorial(6)); // Retrieves from cache
    }
}
