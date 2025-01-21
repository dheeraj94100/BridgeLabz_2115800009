using System;

class ProfitLossCalculator
{
    static void Main(string[] args)
    {
        double costPrice = 129;
        double sellingPrice = 191;

        double profit = sellingPrice - costPrice;
        double profitPercentage = (profit / costPrice) * 100;

        Console.WriteLine($@"The Cost Price is INR {costPrice} and Selling Price is INR {sellingPrice}
The Profit is INR {profit} and the Profit Percentage is {profitPercentage:F2}%");//@ is used to display multiple lines under single console.Writeline
    }
}
