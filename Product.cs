using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public static int TotalProducts = 0; // Shared among all instances

        // Constructor
        public Product(string productName, double price)
        {
            ProductName = productName;
            Price = price;
            TotalProducts++;
        }

        // Instance Method
        public void DisplayProductDetails()
        {
            Console.WriteLine($"Product: {ProductName}, Price: {Price}");
        }

        // Class Method
        public static void DisplayTotalProducts()
        {
            Console.WriteLine($"Total Products: {TotalProducts}");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Enter Product Name: ");
            string productName = Console.ReadLine();
            Console.Write("Enter Product Price: ");
            double productPrice = Convert.ToDouble(Console.ReadLine());

            Product myProduct = new Product(productName, productPrice);
            myProduct.DisplayProductDetails();
            Product.DisplayTotalProducts();
        }
    }
}
