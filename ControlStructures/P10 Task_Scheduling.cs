public class Program10
{
    public static void Run()
    {
        string[] weekDays = ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"];

        for (int i = 0; i < weekDays.Length; i++)
        {
            switch (weekDays[i])
            {
                case "Monday":
                    Console.WriteLine("Team Meeting");
                    break;
                case "Tuesday":
                    Console.WriteLine("Code Review");
                    break;
                case "Wednesday":
                    Console.WriteLine("Development");
                    break;
                case "Thursday":
                    Console.WriteLine("Testing");
                    break;
                case "Friday":
                    Console.WriteLine("Deployment");
                    break;
                default:
                    Console.WriteLine("Rest Day");
                    break;
            }
        }
    }
}