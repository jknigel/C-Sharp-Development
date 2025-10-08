public class Program6
{
    public static void Run()
    {
        string bankAccountType;

        Console.WriteLine("Bank Account Type:");
        bankAccountType = Console.ReadLine();

        double interestRate;
        int monthlyFee;

        switch (bankAccountType)
        {
            case "Savings":
                Console.WriteLine("Apply a 2% interest rate.");
                interestRate = 0.02;
                break;
            case "Checking":
                Console.WriteLine("Apply a $10 monthly fee.");
                monthlyFee = 10;
                break;
            case "Business":
                Console.WriteLine("Apply a 1% interest rate and a $20 monthly fee.");
                interestRate = 0.01;
                monthlyFee = 20;
                break;
            default:
                Console.WriteLine("Invalid Account Type!");
                break;
        }
    }
}
