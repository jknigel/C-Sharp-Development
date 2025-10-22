using System;
using System.Collections.Generic; // Required for using List<T>
using System.Linq; // Used for a cleaner check in DisplayBooks

public class LibraryManager3 // Renamed to avoid confusion
{
    // A constant makes it easy to change the library size later.
    private const int MaxCapacity = 5;

    public static void Run()
    {
        // 1. Use a List<string> to hold the books.
        // This is the single most important change.
        List<string> books = new List<string>();

        while (true)
        {
            Console.WriteLine("\n--- Library Menu ---");
            Console.WriteLine("What would you like to do? (add, remove, display, exit)");
            string? choice = Console.ReadLine()?.ToLower().Trim();

            switch (choice)
            {
                case "add":
                    AddBook(books);
                    break;
                case "remove":
                    RemoveBook(books);
                    break;
                case "display":
                    DisplayBooks(books);
                    break;
                case "exit":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return; // Exit the Main method and the program
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    // 2. Each action is now its own clean, readable method.
    public static void AddBook(List<string> books)
    {
        // The check for "full" is now simple and clear.
        if (books.Count >= MaxCapacity)
        {
            Console.WriteLine("The library is full. No more books can be added.");
            return;
        }

        Console.WriteLine("Enter the title of the book to add:");
        string? newBook = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(newBook))
        {
            Console.WriteLine("Book title cannot be empty.");
            return;
        }

        // Adding to a list is just one line of code.
        books.Add(newBook);
        Console.WriteLine($"'{newBook}' has been added successfully.");
    }

    public static void RemoveBook(List<string> books)
    {
        // The check for "empty" is also simple.
        if (books.Count == 0)
        {
            Console.WriteLine("The library is empty. No books to remove.");
            return;
        }

        Console.WriteLine("Enter the title of the book to remove:");
        string? bookTitleToRemove = Console.ReadLine();
        string? bookFound = null;

        // Find the book, ignoring case. A loop is clear and easy to understand.
        foreach (string book in books)
        {
            if (book.Equals(bookTitleToRemove, StringComparison.OrdinalIgnoreCase))
            {
                bookFound = book;
                break;
            }
        }

        // Removing from a list is also simple.
        if (bookFound != null)
        {
            books.Remove(bookFound);
            Console.WriteLine($"'{bookFound}' has been removed successfully.");
        }
        else
        {
            Console.WriteLine("Book not found.");
        }
    }

    public static void DisplayBooks(List<string> books)
    {
        Console.WriteLine("\n--- Current Books in Library ---");
        
        if (!books.Any()) // .Any() is a clean way from LINQ to check if a list has items.
        {
            Console.WriteLine("The library is currently empty.");
        }
        else
        {
            // A foreach loop is perfect for displaying all items in a list.
            foreach (string book in books)
            {
                Console.WriteLine($"- {book}");
            }
        }
        Console.WriteLine("------------------------------");
    }
}