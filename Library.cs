using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    class Book
    {
        public string ISBN { get; set; }  // Public: Accessible everywhere
        protected string Title { get; set; }  // Protected: Accessible in derived classes
        private string Author;  // Private: Only accessible within the class

        // Constructor
        public Book(string isbn, string title, string author)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
        }

        // Public methods to set and get the author
        public void SetAuthor(string author)
        {
            Author = author;
        }

        public string GetAuthor()
        {
            return Author;
        }

        public void DisplayBookDetails()
        {
            Console.WriteLine($"ISBN: {ISBN}, Title: {Title}, Author: {Author}");
        }
    }

    // Subclass to demonstrate access modifiers
    class EBook : Book
    {
        public int FileSizeMB { get; set; }

        // Constructor calling base class constructor
        public EBook(string isbn, string title, string author, int fileSize) : base(isbn, title, author)
        {
            FileSizeMB = fileSize;
        }

        public void DisplayEBookDetails()
        {
            Console.WriteLine($"E-Book ISBN: {ISBN}, Title: {Title}, File Size: {FileSizeMB}MB");
        }
    }

    class Program
    {
        static void Main()
        {
            Book book = new Book("123-456-789", "C# Programming", "John Doe");
            book.DisplayBookDetails();

            EBook ebook = new EBook("987-654-321", "Advanced C#", "Jane Doe", 5);
            ebook.DisplayEBookDetails();
        }
    }
}
