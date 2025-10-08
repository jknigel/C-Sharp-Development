public class Program2
{
    public static void Run()
    {
        Console.WriteLine("--- This is the code from Lesson 2! ---");

        //Program 2
        string mode;

        Console.WriteLine("Choose mode of transport:");
        mode = Console.ReadLine();

        switch (mode)
        {
            case "Bus":
                Console.WriteLine("Booking a bus ticket.");
                break;
            case "Train":
                Console.WriteLine("Booking a train ticket.");
                break;
            case "Flight":
                Console.WriteLine("Booking a flight ticket.");
                break;
            default:
                Console.WriteLine("Invalid selection. Please choose Bus, Train, or Flight.");
                break;
        }
    }
}
