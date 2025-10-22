using System;

public class LibraryManager
{
    // 1. Create Variables for Books (as required by the prompt)
    // Note: In a real-world application, an array or a List would be much better!
    // For example: static string[] books = new string[5];
    static string book1 = "";
    static string book2 = "";
    static string book3 = "";
    static string book4 = "";
    static string book5 = "";

    public static void Run()
    {
        // 5. Loop Indefinitely
        while (true)
        {
            Console.WriteLine("\n--- Library Menu ---");
            Console.WriteLine("What would you like to do? (add, remove, display, exit)");
            string? choice = Console.ReadLine()?.ToLower().Trim();

            switch (choice)
            {
                case "add":
                    // 7. Conditional Action: Only allow adding if there are empty slots
                    if (GetBookCount() < 5)
                    {
                        AddBook();
                    }
                    else
                    {
                        Console.WriteLine("The library is full. Cannot add more books.");
                    }
                    break;

                case "remove":
                    // 7. Conditional Action: Only allow removing if there are books
                    if (GetBookCount() > 0)
                    {
                        RemoveBook();
                    }
                    else
                    {
                        Console.WriteLine("The library is empty. No books to remove.");
                    }
                    break;

                case "display":
                    DisplayBooks();
                    break;

                case "exit":
                    Console.WriteLine("Exiting the library program. Goodbye!");
                    return; // Exits the Main method and ends the program

                default:
                    // 6. Handle Invalid Inputs
                    Console.WriteLine("Invalid choice. Please type 'add', 'remove', 'display', or 'exit'.");
                    break;
            }
        }
    }

    // 2. Add a Book
    public static void AddBook()
    {
        Console.WriteLine("Enter the title of the book to add:");
        string? newBook = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(newBook))
        {
            Console.WriteLine("Book title cannot be empty.");
            return;
        }

        // Check which book variable is empty and store the new book
        if (string.IsNullOrEmpty(book1)) book1 = newBook;
        else if (string.IsNullOrEmpty(book2)) book2 = newBook;
        else if (string.IsNullOrEmpty(book3)) book3 = newBook;
        else if (string.IsNullOrEmpty(book4)) book4 = newBook;
        else if (string.IsNullOrEmpty(book5)) book5 = newBook;
        
        Console.WriteLine($"'{newBook}' has been added to the library.");
    }

    // 3. Remove a Book
    public static void RemoveBook()
    {
        Console.WriteLine("Enter the title of the book to remove:");
        string? bookToRemove = Console.ReadLine();
        bool bookFound = false;

        if (string.IsNullOrWhiteSpace(bookToRemove))
        {
            Console.WriteLine("Book title cannot be empty.");
            return;
        }

        // Check if the title exists and clear the corresponding variable
        // Using OrdinalIgnoreCase makes the search case-insensitive (e.g., "C#" matches "c#")
        if (bookToRemove.Equals(book1, StringComparison.OrdinalIgnoreCase)) { book1 = ""; bookFound = true; }
        else if (bookToRemove.Equals(book2, StringComparison.OrdinalIgnoreCase)) { book2 = ""; bookFound = true; }
        else if (bookToRemove.Equals(book3, StringComparison.OrdinalIgnoreCase)) { book3 = ""; bookFound = true; }
        else if (bookToRemove.Equals(book4, StringComparison.OrdinalIgnoreCase)) { book4 = ""; bookFound = true; }
        else if (bookToRemove.Equals(book5, StringComparison.OrdinalIgnoreCase)) { book5 = ""; bookFound = true; }

        if (bookFound)
        {
            Console.WriteLine($"'{bookToRemove}' has been removed from the library.");
        }
        else
        {
            Console.WriteLine($"The book '{bookToRemove}' was not found in the library.");
        }
    }

    // 4. Display the List of Books
    public static void DisplayBooks()
    {
        Console.WriteLine("\n--- Current Books in Library ---");
        int currentBookCount = 0;

        // Print out only the non-empty book slots
        if (!string.IsNullOrEmpty(book1)) { Console.WriteLine($"- {book1}"); currentBookCount++; }
        if (!string.IsNullOrEmpty(book2)) { Console.WriteLine($"- {book2}"); currentBookCount++; }
        if (!string.IsNullOrEmpty(book3)) { Console.WriteLine($"- {book3}"); currentBookCount++; }
        if (!string.IsNullOrEmpty(book4)) { Console.WriteLine($"- {book4}"); currentBookCount++; }
        if (!string.IsNullOrEmpty(book5)) { Console.WriteLine($"- {book5}"); currentBookCount++; }

        if (currentBookCount == 0)
        {
            Console.WriteLine("The library is currently empty.");
        }
        Console.WriteLine("------------------------------");
    }

    // Helper method to count the number of books currently in the library
    public static int GetBookCount()
    {
        int count = 0;
        if (!string.IsNullOrEmpty(book1)) count++;
        if (!string.IsNullOrEmpty(book2)) count++;
        if (!string.IsNullOrEmpty(book3)) count++;
        if (!string.IsNullOrEmpty(book4)) count++;
        if (!string.IsNullOrEmpty(book5)) count++;
        return count;
    }
}