using System;
using System.Collections.Generic;

// Abstract class WarehouseItem
public abstract class WarehouseItem
{
    public string Name { get; set; }
    public int Quantity { get; set; }

    public WarehouseItem(string name, int quantity)
    {
        Name = name;
        Quantity = quantity;
    }

    public abstract void Display();
}

// Electronics class
public class Electronics : WarehouseItem
{
    public Electronics(string name, int quantity) : base(name, quantity) { }

    public override void Display()
    {
        Console.WriteLine($"Electronics - Name: {Name}, Quantity: {Quantity}");
    }
}

// Groceries class
public class Groceries : WarehouseItem
{
    public Groceries(string name, int quantity) : base(name, quantity) { }

    public override void Display()
    {
        Console.WriteLine($"Groceries - Name: {Name}, Quantity: {Quantity}");
    }
}

// Furniture class
public class Furniture : WarehouseItem
{
    public Furniture(string name, int quantity) : base(name, quantity) { }

    public override void Display()
    {
        Console.WriteLine($"Furniture - Name: {Name}, Quantity: {Quantity}");
    }
}

// Generic class Storage<T> where T : WarehouseItem
public class Storage<T> where T : WarehouseItem
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public void DisplayItems()
    {
        foreach (var item in items)
        {
            item.Display();
        }
    }
}

// Main class to test the implementation
public class SmartWarehouseManagement
{
    public static void Main(string[] args)
    {
        Storage<Electronics> electronicsStorage = new Storage<Electronics>();
        electronicsStorage.AddItem(new Electronics("Laptop", 10));
        electronicsStorage.AddItem(new Electronics("Smartphone", 20));

        Storage<Groceries> groceriesStorage = new Storage<Groceries>();
        groceriesStorage.AddItem(new Groceries("Apple", 100));
        groceriesStorage.AddItem(new Groceries("Milk", 50));

        Storage<Furniture> furnitureStorage = new Storage<Furniture>();
        furnitureStorage.AddItem(new Furniture("Chair", 15));
        furnitureStorage.AddItem(new Furniture("Table", 5));

        Console.WriteLine("Electronics:");
        electronicsStorage.DisplayItems();

        Console.WriteLine("\nGroceries:");
        groceriesStorage.DisplayItems();

        Console.WriteLine("\nFurniture:");
        furnitureStorage.DisplayItems();
    }
}