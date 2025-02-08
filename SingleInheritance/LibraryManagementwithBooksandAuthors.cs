using System;

// Base class: Book
class Book
{
    public string Title { get; set; }
    public int PublicationYear { get; set; }

    // Constructor
    public Book(string title, int publicationYear)
    {
        Title = title;
        PublicationYear = publicationYear;
    }

    // Virtual method to display book details
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Book Title: {Title}, Publication Year: {PublicationYear}");
    }
}

// Subclass: Author (Inherits from Book)
class Author : Book
{
    public string Name { get; set; }
    public string Bio { get; set; }

    // Constructor
    public Author(string title, int publicationYear, string name, string bio)
        : base(title, publicationYear)
    {
        Name = name;
        Bio = bio;
    }

    // Overriding DisplayInfo method
    public override void DisplayInfo()
    {
        Console.WriteLine($"Book Title: {Title}, Publication Year: {PublicationYear}");
        Console.WriteLine($"Author: {Name}");
        Console.WriteLine($"Bio: {Bio}");
    }
}

// Main class to test the functionality
class Program
{
    static void Main()
    {
        // Creating an Author object (which is also a Book)
        Author author = new Author("The Guide", 1958, "R. K. Narayan", "Renowned Indian writer known for his works set in Malgudi.");

        // Displaying book and author details
        author.DisplayInfo();
    }
}