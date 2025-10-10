public class Program13
{
    public static void Run()
    {
        string[] orderStatuses = { "Pending", "Shipped", "Delivered", "Cancelled" };

        foreach (var status in orderStatuses)
        {
            switch (status)
            {
                case "Pending":
                    Console.WriteLine("Your order is being processed.");
                    break;
                case "Shipped":
                    Console.WriteLine("Your order is on the way.");
                    break;
                case "Delivered":
                    Console.WriteLine("Your order has been delivered.");
                    break;
                case "Cancelled":
                    Console.WriteLine("Your order has been cancelled.");
                    break;
                default:
                    Console.WriteLine("Unknown status.");
                    break;
            }
        }
    }
}