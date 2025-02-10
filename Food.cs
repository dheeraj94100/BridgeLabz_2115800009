using System;
using System.Collections.Generic;

// Abstract class FoodItem
abstract class FoodItem
{
    private string itemName;
    private double price;
    private int quantity;

    public FoodItem(string itemName, double price, int quantity)
    {
        this.itemName = itemName;
        this.price = price;
        this.quantity = quantity;
    }

    public string ItemName { get { return itemName; } }
    public double Price { get { return price; } }
    public int Quantity { get { return quantity; } }

    public abstract double CalculateTotalPrice();

    public virtual void GetItemDetails()
    {
        Console.WriteLine($"Item: {ItemName}, Price: {Price:C}, Quantity: {Quantity}");
    }
}

// Interface for discount eligibility
interface IDiscountable
{
    void ApplyDiscount(double percentage);
    string GetDiscountDetails();
}

// Veg Item
class VegItem : FoodItem, IDiscountable
{
    public VegItem(string itemName, double price, int quantity)
        : base(itemName, price, quantity) { }

    public override double CalculateTotalPrice()
    {
        return Price * Quantity;
    }

    public void ApplyDiscount(double percentage)
    {
        Console.WriteLine($"Discount of {percentage}% applied to {ItemName}.");
    }

    public string GetDiscountDetails()
    {
        return "Veg items have seasonal discounts available.";
    }
}

// Non-Veg Item
class NonVegItem : FoodItem, IDiscountable
{
    private double additionalCharge = 10; // Extra charge for non-veg items

    public NonVegItem(string itemName, double price, int quantity)
        : base(itemName, price, quantity) { }

    public override double CalculateTotalPrice()
    {
        return (Price + additionalCharge) * Quantity;
    }

    public void ApplyDiscount(double percentage)
    {
        Console.WriteLine($"Discount of {percentage}% applied to {ItemName}.");
    }

    public string GetDiscountDetails()
    {
        return "Non-veg items have additional service charges.";
    }
}

class Program
{
    static void Main()
    {
        List<FoodItem> foodItems = new List<FoodItem>();

        Console.Write("Enter number of food items: ");
        int numItems = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < numItems; i++)
        {
            Console.WriteLine("\nEnter details for Food Item " + (i + 1));
            Console.Write("Enter Item Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Item Type (Veg/NonVeg): ");
            string type = Console.ReadLine().ToLower();

            if (type == "veg")
            {
                foodItems.Add(new VegItem(name, price, quantity));
            }
            else if (type == "nonveg")
            {
                foodItems.Add(new NonVegItem(name, price, quantity));
            }
            else
            {
                Console.WriteLine("Invalid Item Type. Skipping entry.");
            }
        }

        Console.WriteLine("\nFood Item Details:");
        foreach (var item in foodItems)
        {
            item.GetItemDetails();
            Console.WriteLine($"Total Price: {item.CalculateTotalPrice():C}");

            if (item is IDiscountable discountable)
            {
                Console.WriteLine(discountable.GetDiscountDetails());
            }
            Console.WriteLine();
        }
    }
}
