using System;

// Base class: Order
class Order
{
    public int OrderId { get; set; }
    public string OrderDate { get; set; }

    // Constructor to initialize order details
    public Order(int orderId, string orderDate)
    {
        OrderId = orderId;
        OrderDate = orderDate;
    }

    // Method to get order status
    public virtual string GetOrderStatus()
    {
        return "Order placed.";
    }

    // Display order details
    public virtual void DisplayOrder()
    {
        Console.WriteLine($"Order ID: {OrderId}, Order Date: {OrderDate}, Status: {GetOrderStatus()}");
    }
}

// Subclass: ShippedOrder (Extends Order)
class ShippedOrder : Order
{
    public string TrackingNumber { get; set; }

    // Constructor to initialize shipped order details
    public ShippedOrder(int orderId, string orderDate, string trackingNumber)
        : base(orderId, orderDate)
    {
        TrackingNumber = trackingNumber;
    }

    // Overriding GetOrderStatus method
    public override string GetOrderStatus()
    {
        return "Order shipped.";
    }

    // Display shipped order details
    public override void DisplayOrder()
    {
        Console.WriteLine($"Order ID: {OrderId}, Order Date: {OrderDate}, Tracking Number: {TrackingNumber}, Status: {GetOrderStatus()}");
    }
}

// Subclass: DeliveredOrder (Extends ShippedOrder)
class DeliveredOrder : ShippedOrder
{
    public string DeliveryDate { get; set; }

    // Constructor to initialize delivered order details
    public DeliveredOrder(int orderId, string orderDate, string trackingNumber, string deliveryDate)
        : base(orderId, orderDate, trackingNumber)
    {
        DeliveryDate = deliveryDate;
    }

    // Overriding GetOrderStatus method
    public override string GetOrderStatus()
    {
        return "Order delivered.";
    }

    // Display delivered order details
    public override void DisplayOrder()
    {
        Console.WriteLine($"Order ID: {OrderId}, Order Date: {OrderDate}, Tracking Number: {TrackingNumber}, Delivery Date: {DeliveryDate}, Status: {GetOrderStatus()}");
    }
}

// Main class to demonstrate functionality
class Program
{
    static void Main()
    {
        // Creating an order
        Order order = new Order(1001, "2024-02-07");
        order.DisplayOrder();

        // Creating a shipped order
        ShippedOrder shippedOrder = new ShippedOrder(1002, "2024-02-06", "TRK123456");
        shippedOrder.DisplayOrder();

        // Creating a delivered order
        DeliveredOrder deliveredOrder = new DeliveredOrder(1003, "2024-02-05", "TRK789123", "2024-02-07");
        deliveredOrder.DisplayOrder();
    }
}