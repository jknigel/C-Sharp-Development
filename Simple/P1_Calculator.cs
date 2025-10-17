public class Calculator
{
    public int number1;
    public int number2;

    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public static void Main()
    {
        int number1 = 10;
        int number2 = 20;
        int sum = Add(number1, number2);
        Console.WriteLine("The sum is: " + sum);
    }
}