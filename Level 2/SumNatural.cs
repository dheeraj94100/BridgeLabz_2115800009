using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a natural number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("Not a natural number.");
            return;
        }

        int recursiveSum = CalculateSumRecursive(n);
        int formulaSum = CalculateSumFormula(n);

        Console.WriteLine("Sum using recursion: " + recursiveSum);
        Console.WriteLine("Sum using formula: " + formulaSum);
        Console.WriteLine("The results are " + (recursiveSum == formulaSum ? "equal." : "not equal."));
    }

    static int CalculateSumRecursive(int n)
    {
        if (n == 1) return 1;
        return n + CalculateSumRecursive(n - 1);
    }

    static int CalculateSumFormula(int n)
    {
        return n * (n + 1) / 2;
    }
}
