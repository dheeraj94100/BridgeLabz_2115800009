using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }

        // Default Constructor
        public Book()
        {
            Title = "Unknown";
            Author = "Unknown";
            Price = 0.0;
        }

        // Parameterized Constructor
        public Book(string title, string author, double price)
        {
            Title = title;
            Author = author;
            Price = price;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Enter Book Title: ");
            string title = Console.ReadLine();
            Console.Write("Enter Book Author: ");
            string author = Console.ReadLine();
            Console.Write("Enter Book Price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            if (title == null || author == null)
            {
                Console.WriteLine("Title and Author cannot be null.");
                return;
            }

            Book myBook = new Book(title, author, price);
            Console.WriteLine($"Book Created: {myBook.Title} by {myBook.Author}, Price: {myBook.Price}");
        }
    }
}

