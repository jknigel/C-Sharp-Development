public class Program1
{
// Method to calculate the final price after a discount
public static double ApplyDiscount(double price, double discountPercentage)
{
    return price * (100-discountPercentage) / 100;
}

public static void Run()
{
    double finalPrice = ApplyDiscount(1000, 15);
    Console.WriteLine("The final price is: " + finalPrice);
}
}