using System.Security.Cryptography.X509Certificates;

public class TaskApp
{
    public static string[] tasks = new string[10];
    public static int taskCount = 0;

    public static void AddTask()
    {
        if (taskCount >= tasks.Length)
        {
            Console.WriteLine("Task list is full!");
            return;
        }

        Console.Write("Enter a new task: ");
        string task = Console.ReadLine() ?? "";
        tasks[taskCount] = task;
        taskCount++;
        Console.WriteLine("Task added.");
    }

    public static void ViewTasks()
    {
        if (taskCount == 0)
        {
            Console.WriteLine("No tasks available.");
            return;
        }

        Console.WriteLine("Your Tasks:");
        for (int i = 0; i < taskCount; i++)
        {
            Console.WriteLine((i + 1) + ". " + tasks[i]);
        }
    }

    public static void CompleteTask()
    {
        Console.Write("Enter the task number to mark as complete: ");
        if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= taskCount)
        {
            tasks[taskCount - 1] = tasks[taskCount - 1] + "(Completed)";
        }
        else
        {
            Console.WriteLine("Invalid task number.");
        }
    }

    public static void Run()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("\nTask Manager");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Complete Task");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine() ?? "";
            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    ViewTasks();
                    break;
                case "3":
                    CompleteTask();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}