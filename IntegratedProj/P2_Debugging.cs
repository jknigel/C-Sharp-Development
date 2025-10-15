using System;
using System.Collections.Generic;

public class TaskManager
{
    static List<string> tasks = new List<string>();
    static List<bool> taskStatus = new List<bool>();

    public static void Run()
    {
        while (true)
        {
            Console.WriteLine("Task Manager");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. Mark Task as Completed");
            Console.WriteLine("3. View Tasks");
            Console.WriteLine("4. Exit");
            Console.WriteLine("What would you like to do? (choose 1-4)");

            string? input = Console.ReadLine();
            string choice = input ?? string.Empty;

            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    CompleteTask();
                    break;
                case "3":
                    ViewTasks();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }

        }
    }

    static void AddTask()
    {
        Console.WriteLine("Enter task description:");
        string task = Console.ReadLine() ?? string.Empty;
        tasks.Add(task);
        taskStatus.Add(false);  // Marking as not completed by default
        Console.WriteLine("Task added successfully.");
    }

    static void CompleteTask()
    {
        Console.WriteLine("Enter task number to mark as completed:");
        int taskNumber;
        int.TryParse(Console.ReadLine(), out taskNumber);

        if (taskNumber <= 0 || taskNumber > tasks.Count)
        {
            Console.WriteLine("Invalid task number.");
            return;
        }

        taskStatus[taskNumber - 1] = true;
        Console.WriteLine($"Task '{tasks[taskNumber-1]}' marked as completed.");
    }

    static void ViewTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks available.");
            return;
        }
        else
        {
            Console.WriteLine("Tasks:");
            for (int i = 0; i < tasks.Count; i++)
            {
                string status = taskStatus[i] ? "Completed" : "Pending";
                Console.WriteLine($"{i + 1}. {tasks[i]} - {status}");
            }
        }
    }
}
