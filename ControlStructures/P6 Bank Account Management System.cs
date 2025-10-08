public class Program6
{
    public static void Run()
    {
        string bankAccountType;

        Console.WriteLine("Bank Account Type:");
        bankAccountType = Console.ReadLine();

        switch (bankAccountType)
        {
            case "Savings":
                Console.WriteLine("Apply a 2% interest rate.");
                break;
            case "Checking":
                Console.WriteLine("Apply a $10 monthly fee.");
                break;
            case "Business":
                Console.WriteLine("Apply a 1% interest rate and a $20 monthly fee.");
                break;
            default:
                Console.WriteLine("Invalid Account Type!");
                break;
        }
    }
}
