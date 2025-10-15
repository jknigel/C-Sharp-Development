using System;
using System.Collections.Generic;

public class TaskItem
{
    public string? Description { get; set; }
    public bool IsComplete { get; set; }
}

public class Program3
{
    public static void Run()
    {
        List<TaskItem> tasks = new List<TaskItem>();
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("1. View Tasks");
            Console.WriteLine("2. Add Task");
            Console.WriteLine("3. Mark Task Complete");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        if (tasks.Count == 0)
                        {
                            Console.WriteLine("No tasks available.");
                        }
                        else
                        {
                            for (int i = 0; i < tasks.Count; i++)
                            {
                                string status = tasks[i].IsComplete ? "[Complete]" : "[Pending]";
                                Console.WriteLine($"{i + 1}. {tasks[i].Description} {status}");
                            }
                        }
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.Write("Enter the task: ");
                        string taskDesc = Console.ReadLine() ?? string.Empty;
                        tasks.Add(new TaskItem { Description = taskDesc, IsComplete = false });
                        Console.WriteLine("Task added. Press Enter to continue...");
                        Console.ReadLine();
                        break;

                    case 3:
                        Console.Write("Enter the task number to mark complete: ");
                        int taskNumber;
                        if (int.TryParse(Console.ReadLine(), out taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
                        {
                            tasks[taskNumber - 1].IsComplete = true;
                            Console.WriteLine("Task marked as complete. Press Enter to continue...");
                        }
                        else
                        {
                            Console.WriteLine("Invalid task number. Press Enter to continue...");
                        }
                        Console.ReadLine();
                        break;

                    case 4:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid option, please try again. Press Enter to continue...");
                        Console.ReadLine();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number. Press Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}