using System;
using System.Collections.Generic;

// Abstract class Product
abstract class Product
{
    private int productId;
    private string name;
    private double price;

    public Product(int id, string name, double price)
    {
        this.productId = id;
        this.name = name;
        this.price = price;
    }

    public int ProductId { get { return productId; } }
    public string Name { get { return name; } }
    public double Price { get { return price; } set { price = value; } }

    public abstract double CalculateDiscount();

    public virtual double GetFinalPrice()
    {
        return Price - CalculateDiscount();
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Product ID: {ProductId}, Name: {Name}, Price: {Price:C}, Final Price: {GetFinalPrice():C}");
    }
}

// Interface for taxable products
interface ITaxable
{
    double CalculateTax();
    string GetTaxDetails();
}

// Electronics category
class Electronics : Product, ITaxable
{
    public Electronics(int id, string name, double price) : base(id, name, price) { }

    public override double CalculateDiscount()
    {
        return Price * 0.10; // 10% discount
    }

    public double CalculateTax()
    {
        return Price * 0.15; // 15% tax
    }

    public string GetTaxDetails()
    {
        return "Electronics Tax: 15%";
    }

    public override double GetFinalPrice()
    {
        return Price + CalculateTax() - CalculateDiscount();
    }
}

// Clothing category
class Clothing : Product, ITaxable
{
    public Clothing(int id, string name, double price) : base(id, name, price) { }

    public override double CalculateDiscount()
    {
        return Price * 0.20; // 20% discount
    }

    public double CalculateTax()
    {
        return Price * 0.05; // 5% tax
    }

    public string GetTaxDetails()
    {
        return "Clothing Tax: 5%";
    }

    public override double GetFinalPrice()
    {
        return Price + CalculateTax() - CalculateDiscount();
    }
}

// Groceries category
class Groceries : Product
{
    public Groceries(int id, string name, double price) : base(id, name, price) { }

    public override double CalculateDiscount()
    {
        return Price * 0.05; // 5% discount
    }
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>();

        Console.Write("Enter number of products: ");
        int numProducts = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < numProducts; i++)
        {
            Console.WriteLine("\nEnter details for Product " + (i + 1));
            Console.Write("Enter Product ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Product Type (Electronics/Clothing/Groceries): ");
            string type = Console.ReadLine().ToLower();

            if (type == "electronics")
            {
                products.Add(new Electronics(id, name, price));
            }
            else if (type == "clothing")
            {
                products.Add(new Clothing(id, name, price));
            }
            else if (type == "groceries")
            {
                products.Add(new Groceries(id, name, price));
            }
            else
            {
                Console.WriteLine("Invalid Product Type. Skipping entry.");
            }
        }

        Console.WriteLine("\nProduct Details:");
        foreach (var product in products)
        {
            product.DisplayDetails();
        }
    }
}
