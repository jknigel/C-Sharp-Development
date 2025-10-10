public class Program11
{
    public static void Run()
    {
        do
        {
            Console.WriteLine("Enter an even number between 1 to 10");

            string? input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Input cannot be empty. Please try again.");
                continue;
            }
            int number = int.Parse(input);

            if (number >= 1 && number <= 10 && number % 2 == 0)
            {
                Console.WriteLine("Well Done!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid input, please try again.");
            }

        } while (true);
    }
}