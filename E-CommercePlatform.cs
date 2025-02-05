using System;
using System.Collections.Generic;

namespace ECommercePlatform
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(int productId, string name, decimal price)
        {
            ProductId = productId;
            Name = name;
            Price = price;
        }
    }

    public class Order
    {
        public int OrderId { get; set; }
        public Customer Customer { get; set; }
        public List<Product> Products { get; set; }
        public DateTime OrderDate { get; set; }

        public Order(int orderId, Customer customer)
        {
            OrderId = orderId;
            Customer = customer;
            Products = new List<Product>();
            OrderDate = DateTime.Now;
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public decimal GetTotalAmount()
        {
            decimal total = 0;
            foreach (var product in Products)
            {
                total += product.Price;
            }
            return total;
        }
    }

    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Order> Orders { get; set; }

        public Customer(int customerId, string name, string email)
        {
            CustomerId = customerId;
            Name = name;
            Email = email;
            Orders = new List<Order>();
        }

        public void PlaceOrder(Order order)
        {
            Orders.Add(order);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create some products
            Product product1 = new Product(1, "Laptop", 999.99m);
            Product product2 = new Product(2, "Smartphone", 499.99m);

            // Create a customer
            Customer customer = new Customer(1, "John Doe", "john.doe@example.com");

            // Create an order and add products to it
            Order order = new Order(1, customer);
            order.AddProduct(product1);
            order.AddProduct(product2);

            // Customer places the order
            customer.PlaceOrder(order);

            // Display order details
            Console.WriteLine($"Customer: {customer.Name}");
            Console.WriteLine($"Order ID: {order.OrderId}");
            Console.WriteLine("Products in the order:");
            foreach (var product in order.Products)
            {
                Console.WriteLine($"- {product.Name}: ${product.Price}");
            }
            Console.WriteLine($"Total Amount: ${order.GetTotalAmount()}");
        }
    }
}