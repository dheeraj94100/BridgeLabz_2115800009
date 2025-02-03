using System;

class Product
{
    private static double Discount = 10; // Static variable shared by all products

    public readonly int ProductID;  // Readonly variable (cannot change after assignment)
    public string ProductName;
    public double Price;
    public int Quantity;

    // Constructor using 'this' to initialize properties
    public Product(string productName, double price, int quantity)
    {
        this.ProductID = new Random().Next(1000, 9999); // Generate unique ProductID
        this.ProductName = productName;
        this.Price = price;
        this.Quantity = quantity;
    }

    // Static method to update the discount
    public static void UpdateDiscount(double newDiscount)
    {
        Discount = newDiscount;
        Console.WriteLine($"Discount updated to: {Discount}%");
    }

    // Calculate total price for this product with discount
    public double CalculateTotalPrice()
    {
        return (Price * Quantity) * (1 - Discount / 100);
    }

    // Display product details using 'is' operator for type checking
    public void DisplayProductInfo()
    {
        if (this is Product)  // Check if the object is an instance of Product
        {
            Console.WriteLine("\n--- Product Details ---");
            Console.WriteLine($"Product ID: {ProductID}");
            Console.WriteLine($"Product Name: {ProductName}");
            Console.WriteLine($"Price: ${Price}");
            Console.WriteLine($"Quantity: {Quantity}");
            Console.WriteLine($"Total Price after Discount: ${CalculateTotalPrice():0.00}\n");
        }
        else
        {
            Console.WriteLine("Invalid product record!");
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of products: ");
        int productCount = Convert.ToInt32(Console.ReadLine());

        Product[] products = new Product[productCount];

        for (int i = 0; i < productCount; i++)
        {
            Console.WriteLine($"\nEnter details for Product {i + 1}:");

            Console.Write("Enter Product Name: ");
            string productName = Console.ReadLine();

            Console.Write("Enter Price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            products[i] = new Product(productName, price, quantity);
        }

        // Display all product details
        Console.WriteLine("\nAll Product Details:");
        foreach (Product product in products)
        {
            product.DisplayProductInfo();
        }

        // Update discount if needed
        Console.Write("\nDo you want to update the discount for all products? (yes/no): ");
        string response = Console.ReadLine();

        if (response.ToLower() == "yes")
        {
            Console.Write("Enter the new discount percentage: ");
            double newDiscount = Convert.ToDouble(Console.ReadLine());

            Product.UpdateDiscount(newDiscount); // Update discount for all products
        }

        // Display product details again after discount update
        Console.WriteLine("\nUpdated Product Details:");
        foreach (Product product in products)
        {
            product.DisplayProductInfo();
        }
    }
}
