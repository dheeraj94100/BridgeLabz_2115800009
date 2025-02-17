using System;
using System.Diagnostics;

class FibonacciComparison
{
    // Recursive Fibonacci (O(2^N))
    static long RecursiveFibonacci(long n)
    {
        if (n <= 1)
            return n;
        return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
    }

    // Iterative Fibonacci (O(N))
    static long IterativeFibonacci(long n)
    {
        if (n <= 1)
            return n;

        long a = 0, b = 1, c = 0;
        for (long i = 2; i <= n; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }
        return c;
    }

    static void Main(string[] args)
    {
        long []arr = {10, 30, 50};// example value

        Console.WriteLine("Recursive Fibonacci:");
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        foreach (long i in arr)
        {
            Console.WriteLine($"Fib({i}) = {RecursiveFibonacci(i)}");
            stopwatch.Stop();
            Console.WriteLine($"Recursive Fibonacci Time: {stopwatch.ElapsedMilliseconds} ms");
            stopwatch.Restart();
        }
        stopwatch.Stop();
        Console.WriteLine("\nIterative Fibonacci:");
        foreach (long i in arr)
        {
            stopwatch.Restart();
            Console.WriteLine($"Fib({i}) = {IterativeFibonacci(i)}");
            stopwatch.Stop();
            Console.WriteLine($"Iterative Fibonacci Time: {stopwatch.ElapsedMilliseconds} ms");
        }
        stopwatch.Stop();
    }
}