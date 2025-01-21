using System;

class DiscountFee {
    static void Main() {
        Console.WriteLine("Enter the fee amount (INR):");
        double fee = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter the discount percentage:");
        double discountPercent = Convert.ToDouble(Console.ReadLine());
        
        double discountAmount = (fee * discountPercent) / 100;
        double discountedFee = fee - discountAmount;

        Console.WriteLine($"The discount amount is INR {discountAmount:F2} and final discounted fee is INR {discountedFee:F2}.");
    }
}