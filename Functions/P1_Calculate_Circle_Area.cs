public class Program1
{
    public static void Run()
    {
        double calculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        Console.WriteLine("Enter the radius of the circle:");
        string? input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Input cannot be empty.");
            return;
        }
        double radius = double.Parse(input);
        double area = calculateCircleArea(radius);
        Console.WriteLine($"The area of the circle with radius {radius} is {area}");
    }
}