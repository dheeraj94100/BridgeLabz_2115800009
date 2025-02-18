using System;
using System.Collections.Generic;

// Base class for product categories
public abstract class Category
{
    public string Name { get; set; }

    public Category(string name)
    {
        Name = name;
    }
}

// Derived class for BookCategory
public class BookCategory : Category
{
    public BookCategory(string name) : base(name) { }
}

// Derived class for ClothingCategory
public class ClothingCategory : Category
{
    public ClothingCategory(string name) : base(name) { }
}

// Generic Product class constrained to Category
public class Product<T> where T : Category
{
    public string Name { get; set; }
    public double Price { get; set; }
    public T Category { get; set; }

    public Product(string name, double price, T category)
    {
        Name = name;
        Price = price;
        Category = category;
    }

    public void DisplayProductDetails()
    {
        Console.WriteLine($"Product: {Name}, Category: {Category.Name}, Price: ${Price}");
    }
}

// Generic method to apply discount to a product
public static class DiscountManager
{
    public static void ApplyDiscount<T>(Product<T> product, double percentage) where T : Category
    {
        if (percentage < 0 || percentage > 100)
        {
            throw new ArgumentException("Discount percentage must be between 0 and 100.");
        }

        product.Price -= product.Price * (percentage / 100);
        Console.WriteLine($"Applied {percentage}% discount to {product.Name}. New price: ${product.Price}");
    }
}

// Main program
public class Program
{
    public static void Main(string[] args)
    {
        // Create categories
        var bookCategory = new BookCategory("Books");
        var clothingCategory = new ClothingCategory("Clothing");

        // Create products
        var bookProduct = new Product<BookCategory>("C# Programming", 50.0, bookCategory);
        var clothingProduct = new Product<ClothingCategory>("T-Shirt", 20.0, clothingCategory);

        // Display product details
        Console.WriteLine("Product Details:");
        bookProduct.DisplayProductDetails();
        clothingProduct.DisplayProductDetails();

        // Apply discounts
        Console.WriteLine("\nApplying Discounts:");
        DiscountManager.ApplyDiscount(bookProduct, 10); // 10% discount on book
        DiscountManager.ApplyDiscount(clothingProduct, 20); // 20% discount on clothing

        // Display updated product details
        Console.WriteLine("\nUpdated Product Details:");
        bookProduct.DisplayProductDetails();
        clothingProduct.DisplayProductDetails();
    }
}