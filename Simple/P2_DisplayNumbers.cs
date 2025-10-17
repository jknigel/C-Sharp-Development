public class NumberDisplay
{
    public static void DisplayNumbers()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Number: " + i);
        }
    }

    public static void Run()
    {
        DisplayNumbers();
    }
}