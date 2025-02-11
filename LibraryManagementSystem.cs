using System;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public int BookID { get; set; }
    public bool IsAvailable { get; set; }
    public Book Next { get; set; }
    public Book Prev { get; set; }

    public Book(string title, string author, string genre, int bookID, bool isAvailable)
    {
        Title = title;
        Author = author;
        Genre = genre;
        BookID = bookID;
        IsAvailable = isAvailable;
        Next = null;
        Prev = null;
    }
}

public class LibraryManagementSystem
{
    private Book head;
    private Book tail;
    private int count;

    public LibraryManagementSystem()
    {
        head = null;
        tail = null;
        count = 0;
    }

    public void AddBookAtBeginning(Book newBook)
    {
        if (head == null)
        {
            head = newBook;
            tail = newBook;
        }
        else
        {
            newBook.Next = head;
            head.Prev = newBook;
            head = newBook;
        }
        count++;
    }

    public void AddBookAtEnd(Book newBook)
    {
        if (tail == null)
        {
            head = newBook;
            tail = newBook;
        }
        else
        {
            tail.Next = newBook;
            newBook.Prev = tail;
            tail = newBook;
        }
        count++;
    }

    public void AddBookAtPosition(Book newBook, int position)
    {
        if (position < 1 || position > count + 1)
        {
            Console.WriteLine("Invalid position!");
            return;
        }

        if (position == 1)
        {
            AddBookAtBeginning(newBook);
            return;
        }

        if (position == count + 1)
        {
            AddBookAtEnd(newBook);
            return;
        }

        Book current = head;
        for (int i = 1; i < position - 1; i++)
        {
            current = current.Next;
        }

        newBook.Next = current.Next;
        newBook.Prev = current;
        current.Next.Prev = newBook;
        current.Next = newBook;
        count++;
    }

    public void RemoveBookByID(int bookID)
    {
        Book current = head;
        while (current != null)
        {
            if (current.BookID == bookID)
            {
                if (current.Prev != null)
                {
                    current.Prev.Next = current.Next;
                }
                else
                {
                    head = current.Next;
                }

                if (current.Next != null)
                {
                    current.Next.Prev = current.Prev;
                }
                else
                {
                    tail = current.Prev;
                }

                count--;
                return;
            }
            current = current.Next;
        }
        Console.WriteLine("Book not found!");
    }

    public Book SearchBookByTitleOrAuthor(string query)
    {
        Book current = head;
        while (current != null)
        {
            if (current.Title.Equals(query, StringComparison.OrdinalIgnoreCase) || current.Author.Equals(query, StringComparison.OrdinalIgnoreCase))
            {
                return current;
            }
            current = current.Next;
        }
        return null;
    }

    public void UpdateBookAvailabilityStatus(int bookID, bool isAvailable)
    {
        Book current = head;
        while (current != null)
        {
            if (current.BookID == bookID)
            {
                current.IsAvailable = isAvailable;
                return;
            }
            current = current.Next;
        }
        Console.WriteLine("Book not found!");
    }

    public void DisplayBooksForward()
    {
        Book current = head;
        while (current != null)
        {
            Console.WriteLine($"Title: {current.Title}, Author: {current.Author}, Genre: {current.Genre}, BookID: {current.BookID}, Available: {current.IsAvailable}");
            current = current.Next;
        }
    }

    public void DisplayBooksReverse()
    {
        Book current = tail;
        while (current != null)
        {
            Console.WriteLine($"Title: {current.Title}, Author: {current.Author}, Genre: {current.Genre}, BookID: {current.BookID}, Available: {current.IsAvailable}");
            current = current.Prev;
        }
    }

    public int CountBooks()
    {
        return count;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        LibraryManagementSystem library = new LibraryManagementSystem();

        Book book1 = new Book("Book One", "Author One", "Genre One", 1, true);
        Book book2 = new Book("Book Two", "Author Two", "Genre Two", 2, true);
        Book book3 = new Book("Book Three", "Author Three", "Genre Three", 3, true);

        library.AddBookAtBeginning(book1);
        library.AddBookAtEnd(book2);
        library.AddBookAtPosition(book3, 2);

        library.DisplayBooksForward();
        Console.WriteLine("Total Books: " + library.CountBooks());

        library.RemoveBookByID(2);
        library.DisplayBooksForward();
        Console.WriteLine("Total Books: " + library.CountBooks());

        Book searchResult = library.SearchBookByTitleOrAuthor("Book One");
        if (searchResult != null)
        {
            Console.WriteLine($"Found Book: {searchResult.Title}, Author: {searchResult.Author}");
        }
        else
        {
            Console.WriteLine("Book not found!");
        }

        library.UpdateBookAvailabilityStatus(1, false);
        library.DisplayBooksForward();
    }
}