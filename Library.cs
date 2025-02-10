using System;
using System.Collections.Generic;

// Abstract class LibraryItem
abstract class LibraryItem
{
    private string itemId;
    private string title;
    private string author;

    public LibraryItem(string itemId, string title, string author)
    {
        this.itemId = itemId;
        this.title = title;
        this.author = author;
    }

    public string ItemId { get { return itemId; } }
    public string Title { get { return title; } }
    public string Author { get { return author; } }

    public abstract int GetLoanDuration();

    public virtual void GetItemDetails()
    {
        Console.WriteLine($"Item ID: {ItemId}, Title: {Title}, Author: {Author}");
    }
}

// Interface for reservable items
interface IReservable
{
    void ReserveItem();
    bool CheckAvailability();
}

// Book subclass
class Book : LibraryItem, IReservable
{
    public Book(string itemId, string title, string author)
        : base(itemId, title, author) { }

    public override int GetLoanDuration()
    {
        return 14; // 14 days loan duration
    }

    public void ReserveItem()
    {
        Console.WriteLine("Book reserved successfully.");
    }

    public bool CheckAvailability()
    {
        return true; // Assume always available
    }
}

// Magazine subclass
class Magazine : LibraryItem
{
    public Magazine(string itemId, string title, string author)
        : base(itemId, title, author) { }

    public override int GetLoanDuration()
    {
        return 7; // 7 days loan duration
    }
}

// DVD subclass
class DVD : LibraryItem, IReservable
{
    public DVD(string itemId, string title, string author)
        : base(itemId, title, author) { }

    public override int GetLoanDuration()
    {
        return 5; // 5 days loan duration
    }

    public void ReserveItem()
    {
        Console.WriteLine("DVD reserved successfully.");
    }

    public bool CheckAvailability()
    {
        return false; // Assume currently unavailable
    }
}

class Program
{
    static void Main()
    {
        List<LibraryItem> libraryItems = new List<LibraryItem>();

        Console.Write("Enter number of library items: ");
        int numItems = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < numItems; i++)
        {
            Console.WriteLine($"\nEnter details for Library Item {i + 1}");
            Console.Write("Enter Item ID: ");
            string itemId = Console.ReadLine();

            Console.Write("Enter Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter Author: ");
            string author = Console.ReadLine();

            Console.Write("Enter Item Type (Book/Magazine/DVD): ");
            string type = Console.ReadLine().ToLower();

            if (type == "book")
            {
                libraryItems.Add(new Book(itemId, title, author));
            }
            else if (type == "magazine")
            {
                libraryItems.Add(new Magazine(itemId, title, author));
            }
            else if (type == "dvd")
            {
                libraryItems.Add(new DVD(itemId, title, author));
            }
            else
            {
                Console.WriteLine("Invalid Item Type. Skipping entry.");
            }
        }

        Console.WriteLine("\nLibrary Items Details:");
        foreach (var item in libraryItems)
        {
            item.GetItemDetails();
            Console.WriteLine($"Loan Duration: {item.GetLoanDuration()} days");

            if (item is IReservable reservable)
            {
                Console.WriteLine("Availability: " + (reservable.CheckAvailability() ? "Available" : "Not Available"));
                reservable.ReserveItem();
            }
            Console.WriteLine();
        }
    }
}
