using System;
using System.Collections.Generic;
using System.Linq;

class ShoppingCart
{
    static void Main()
    {
        Dictionary<string, double> productPrices = new Dictionary<string, double>(); // Stores product prices
        LinkedList<KeyValuePair<string, double>> orderedProducts = new LinkedList<KeyValuePair<string, double>>(); // Maintains order
        SortedDictionary<double, List<string>> sortedProducts = new SortedDictionary<double, List<string>>(); // Sorts by price

        Console.Write("Enter the number of products: ");
        int numProducts = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < numProducts; i++)
        {
            Console.Write($"Enter product name {i + 1}: ");
            string product = Console.ReadLine();

            Console.Write($"Enter price for {product}: ");
            double price = Convert.ToDouble(Console.ReadLine());

            // Store in dictionary
            productPrices[product] = price;

            // Maintain order
            orderedProducts.AddLast(new KeyValuePair<string, double>(product, price));

            // Sort by price
            if (!sortedProducts.ContainsKey(price))
                sortedProducts[price] = new List<string>();
            
            sortedProducts[price].Add(product);
        }

        // Display products in order of addition
        Console.WriteLine("\nProducts in Order of Addition:");
        foreach (var item in orderedProducts)
        {
            Console.WriteLine($"{item.Key}: ${item.Value:F2}");
        }

        // Display products sorted by price
        Console.WriteLine("\nProducts Sorted by Price:");
        foreach (var kvp in sortedProducts)
        {
            foreach (var product in kvp.Value)
            {
                Console.WriteLine($"{product}: ${kvp.Key:F2}");
            }
        }

        // Display total cost
        double total = productPrices.Values.Sum();
        Console.WriteLine($"\nTotal Cost: ${total:F2}");
    }
}
