using System;

class Book
{
    private static string LibraryName = "City Central Library";  // Static variable shared by all books

    public readonly string ISBN;  // Readonly variable (cannot change after assignment)
    public string Title;
    public string Author;

    // Constructor using 'this' to initialize properties
    public Book(string Title, string Author, string ISBN)
    {
        this.Title = Title;
        this.Author = Author;
        this.ISBN = ISBN;
    }

    // Static method to display library name
    public static void DisplayLibraryName()
    {
        Console.WriteLine($"Library: {LibraryName}");
    }

    // Display book details using 'is' operator for type checking
    public void DisplayBookInfo()
    {
        if (this is Book)  // Checking if object is an instance of Book
        {
            Console.WriteLine("\n--- Book Details ---");
            Console.WriteLine($"Library: {LibraryName}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"ISBN: {ISBN}\n");
        }
        else
        {
            Console.WriteLine("Invalid book object!");
        }
    }
}

class Program
{
    static void Main()
    {
        // Display library name using static method
        Book.DisplayLibraryName();

        // Taking user input for books
        Console.Write("Enter the number of books to add: ");
        int bookCount = Convert.ToInt32(Console.ReadLine());

        Book[] books = new Book[bookCount];

        for (int i = 0; i < bookCount; i++)
        {
            Console.WriteLine($"\nEnter details for Book {i + 1}:");

            Console.Write("Enter Book Title: ");
            string title = Convert.ToString(Console.ReadLine());

            Console.Write("Enter Author Name: ");
            string author = Convert.ToString(Console.ReadLine());

            Console.Write("Enter ISBN: ");
            string isbn = Convert.ToString(Console.ReadLine());

            books[i] = new Book(title, author, isbn);
        }

        // Displaying all books
        Console.WriteLine("\nAll Books in the Library:");
        foreach (Book book in books)
        {
            book.DisplayBookInfo();
        }
    }
}
