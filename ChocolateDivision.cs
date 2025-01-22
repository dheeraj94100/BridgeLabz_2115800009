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
        Console.WriteLine("\nThe number of chocolated each child gets is:");
        Console.WriteLine($"{chocolatesPerChild}");
        Console.WriteLine($"and the number of remaining chocolates is {remainingChocolates}.");
    }
}
