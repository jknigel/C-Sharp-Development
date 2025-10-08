public class Program1
{
    public static void Run()
    {
        Console.WriteLine("--- This is the code from Lesson 1! ---");

        // Program 1
        int age;

        Console.WriteLine("Enter passenger's age:");
        age = int.Parse(Console.ReadLine());

        if (age < 12)
        {
            Console.WriteLine("Half price ticket.");
        }
        else if (age >= 12 && age <= 65)
        {
            Console.WriteLine("Full price ticket.");
        }
        else
        {
            Console.WriteLine("Senior discount ticket.");
        }
    }
}