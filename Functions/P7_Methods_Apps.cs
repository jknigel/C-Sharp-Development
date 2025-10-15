public class Program7
{
    public static void Run()
    {
        DisplayWelcomeMessage();
        GreetUser("Alice");
        CalculateSum(7, 8);

        if (IsPositive(9))
        {
            Console.WriteLine("The number is positive");
        }
        else
        {
            Console.WriteLine("The number is not positive");
        }

        Console.WriteLine("Enter your age: ");
        int age;
        int.TryParse(Console.ReadLine(), out age);

        if (IsOldEnoughToDrive(age))
        {
            Console.WriteLine("You are old enough to drive.");
        }
        else
        {
            Console.WriteLine("You are not old enough to drive.");
        }
    }

    public static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    public static void GreetUser(string name)
    {
        Console.WriteLine("Hello " + name + "!");
    }

    public static void CalculateSum(int a, int b)
    {
        int result = a + b;
        Console.WriteLine(result);
    }

    public static bool IsPositive(int number)
    {
        if (number > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    public static bool IsOldEnoughToDrive(int age)
    {
        if (age >= 18)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}