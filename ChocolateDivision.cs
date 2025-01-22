using System;

class DistributeChocolates
{
    static void Main(string[] args)
    {
        // Prompt user for number of chocolates and children
        Console.WriteLine("Enter the number of chocolates:");
        int numberOfChocolates = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number of children:");
        int numberOfChildren = int.Parse(Console.ReadLine());

        // Calculate chocolates per child and remaining chocolates
        int chocolatesPerChild = numberOfChocolates / numberOfChildren;
        int remainingChocolates = numberOfChocolates % numberOfChildren;

        // Display results
        Console.WriteLine($"Each child gets {chocolatesPerChild} chocolates. Remaining chocolates: {remainingChocolates}");
    }
}
