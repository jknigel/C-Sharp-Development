using System;
public class Program6
{
    public static void Run()
    {
        int volumeBox = CalculateVolumeOfBox(7, 8, 9);
        Console.WriteLine($"The volume is {volumeBox}");

        Console.WriteLine("Enter Number 1:");
        string? number1 = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(number1))
        {
            Console.WriteLine("Input cannot be empty.");
            return;
        }
        int num1 = int.Parse(number1);

        Console.WriteLine("Enter Number 2:");
        string? number2 = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(number2))
        {
            Console.WriteLine("Input cannot be empty.");
            return;
        }
        int num2 = int.Parse(number2);

        Console.WriteLine("Enter Number 3:");
        string? number3 = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(number3))
        {
            Console.WriteLine("Input cannot be empty.");
            return;
        }
        int num3 = int.Parse(number3);

        int averageResult = CalculateAverage(num1, num2, num3);
        Console.WriteLine($"The average is {averageResult}");
    }

    public static int CalculateVolumeOfBox(int length, int width, int height)
    {
        return length * width * height;
    }

    public static int CalculateAverage(int num1, int num2, int num3)
    {
        int total = num1 + num2 + num3;
        int average = total / 3;
        return average;
    }
}