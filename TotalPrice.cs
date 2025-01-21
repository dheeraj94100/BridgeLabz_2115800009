using System;

class TotalPrice {
    static void Main() {
        Console.WriteLine("Enter the unit price of the item (INR):");
        double unitPrice = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter the quantity to be bought:");
        int quantity = Convert.ToInt32(Console.ReadLine());
        
        double totalPrice = unitPrice * quantity;
        
        Console.WriteLine($"The total purchase price is INR {totalPrice:F2} if the quantity is {quantity} and the unit price is INR {unitPrice:F2}.");
    }
}