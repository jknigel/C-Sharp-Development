public class Program5
{
    public static void Run()
    {
        //Program 5
        int age;
        string memberType;

        Console.WriteLine("What is your age?");
        age = int.Parse(Console.ReadLine());

        Console.WriteLine("Which membership type do you want? (Basic or Premium)");
        memberType = Console.ReadLine();

        switch (age)
        {
            case <18:
                if (memberType == "Basic")
                {
                    Console.WriteLine("The fee is $15");
                }
                else if (memberType == "Premium")
                {
                    Console.WriteLine("The fee is $25");
                }
                else
                {
                    Console.WriteLine("Invalid membership type");
                }
                break;

            case >= 18 and <=60:
                if (memberType == "Basic")
                {
                    Console.WriteLine("The fee is $30");
                }
                else if (memberType == "Premium")
                {
                    Console.WriteLine("The fee is $50");
                }
                else
                {
                    Console.WriteLine("Invalid membership type");
                }
                break;

            case >60:
                if (memberType == "Basic")
                {
                    Console.WriteLine("The fee is $20");
                }
                else if (memberType == "Premium")
                {
                    Console.WriteLine("The fee is $35");
                }
                else
                {
                    Console.WriteLine("Invalid membership type");
                }
                break;

            default:
                Console.WriteLine("Invalid age.");
                break;
        }
    }
}
