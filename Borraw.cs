using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    class Book
    {
        public string Title { get; }
        public string Author { get; }
        public double Price { get; }
        private bool IsAvailable;

        // Constructor
        public Book(string title, string author, double price)
        {
            Title = title;
            Author = author;
            Price = price;
            IsAvailable = true;
        }

        // Method to borrow book
        public void BorrowBook()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine($"'{Title}' has been borrowed.");
            }
            else
            {
                Console.WriteLine($"'{Title}' is currently not available.");
            }
        }

        public void DisplayBook()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, Price: {Price}, Available: {IsAvailable}");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Enter Book Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter Author Name: ");
            string author = Console.ReadLine();

            Console.Write("Enter Book Price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Book book = new Book(title, author, price);
            book.DisplayBook();

            Console.Write("Do you want to borrow this book? (yes/no): ");
            string borrowChoice = Console.ReadLine().ToLower();
            if (borrowChoice == "yes")
            {
                book.BorrowBook();
            }

            book.DisplayBook();
        }
    }
}
