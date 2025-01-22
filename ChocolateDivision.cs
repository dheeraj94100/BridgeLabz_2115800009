using System;

class ChocolateDivision
{
    static void Main(string[] args)
    {
        // Taking user input for the number of chocolates and number of children
        Console.Write("Enter the number of chocolates: ");
        int numberOfChocolates = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of children: ");
        int numberOfChildren = Convert.ToInt32(Console.ReadLine());

        // Calculating the number of chocolates each child gets and the number of remaining chocolates
        int chocolatesPerChild = numberOfChocolates / numberOfChildren;
        int remainingChocolates = numberOfChocolates % numberOfChildren;

        // Displaying the results
        Console.WriteLine("\nThe results of chocolate distribution:");
        Console.WriteLine($"Each child gets {chocolatesPerChild} chocolates.");
        Console.WriteLine($"The remaining chocolates are {remainingChocolates}.");
    }
}
