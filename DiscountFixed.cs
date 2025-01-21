using System;

class DiscountFixed {
    static void Main() {
        double fee = 125000;
        double discountPercent = 10;
        double discountAmount = (fee * discountPercent) / 100;
        double discountedFee = fee - discountAmount;

        Console.WriteLine($"The discount amount is INR {discountAmount:F2} and final discounted fee is INR {discountedFee:F2}.");
    }
}