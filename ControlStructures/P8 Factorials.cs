public class Program8
{
    public static void Run()
    {
        int number = 5;
        int factorial = 1;

        while (number > 0)
        {
            factorial *= number;
            number--;
        }

        Console.WriteLine(factorial);
    }
}