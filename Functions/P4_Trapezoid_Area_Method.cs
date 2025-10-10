public class Program4
{
    public static void Run()
    {
        static double calculateTrapezoidArea(double L1, double L2, double height)
        {
            return 0.5 * (L1 + L2) * height;
        }

        Console.WriteLine("Enter Legnth 1:");
        string? l1 = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(l1))
        {
            Console.WriteLine("Input cannot be empty.");
            return;
        }
        Console.WriteLine("Enter Legnth 2:");
        string? l2 = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(l2))
        {
            Console.WriteLine("Input cannot be empty.");
            return;
        }
        Console.WriteLine("Enter Height:");
        string? h1 = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(h1))
        {
            Console.WriteLine("Input cannot be empty.");
            return;
        }
        double length1 = double.Parse(l1);
        double length2 = double.Parse(l2);
        double height = double.Parse(h1);
        double area = calculateTrapezoidArea(length1, length2, height);

        Console.WriteLine($"The area of the trapezoid with legs {length1}, {length2} and height {height} is {area}");
    }
}