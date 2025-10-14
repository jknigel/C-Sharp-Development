using System.IO.Pipelines;
using System.Runtime.InteropServices.Marshalling;

public class Program5
{
    public static void Run()
    {
        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to our Program!");
        }

        DisplayWelcomeMessage();

        static void GreetUser(string name)
        {
            Console.WriteLine("Hello " + name + "!");
        }

        GreetUser("Alice");

        static int CalculateSum(int a, int b)
        {
            return a + b;
        }

        int result = CalculateSum(7, 8);
        Console.WriteLine(result);

        static bool IsPositive(int number)
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
        bool isPositive = IsPositive(9);
        if (isPositive)
        {
            Console.WriteLine("The number is positive");
        }
        else
        {
            Console.WriteLine("The number is not positive");
        }

        static bool IsOldEnoughToDrive(int age)
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
        Console.WriteLine("Enter your age: ");
        string? age_input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(age_input))
        {
            Console.WriteLine("Input cannot be empty.");
            return;
        }
        int age = int.Parse(age_input);
        bool drivingAge = IsOldEnoughToDrive(age);

        if (drivingAge)
        {
            Console.WriteLine("Old enough to drive!");
        }
        else
        {
            Console.WriteLine("You are not old enough to drive!");
        }
        
    }
}