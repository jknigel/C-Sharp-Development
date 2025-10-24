using System;
using System.Collections.Generic;
using System.Linq;

// A class to represent a single book with its properties.
public class Book
{
    public string Title { get; set; }
    public bool IsCheckedOut { get; set; }

    // A constructor to make creating new books easier.
    // A new book is always available by default.
    public Book(string title)
    {
        Title = title;
        IsCheckedOut = false; 
    }
}
public class AdvancedLibraryManager
{
    private const int MaxCapacity = 5;
    private const int BorrowLimit = 3;

    public static void Main()
    {
        // We now use a List of Book objects instead of a List of strings.
        List<Book> library = new List<Book>();

        while (true)
        {
            Console.WriteLine("\n--- Advanced Library Menu ---");
            Console.WriteLine("Options: add, remove, display, search, checkout, checkin, exit");
            string? choice = Console.ReadLine()?.ToLower().Trim();

            switch (choice)
            {
                case "add":
                    AddBook(library);
                    break;
                case "remove":
                    RemoveBook(library);
                    break;
                case "display":
                    DisplayBooks(library);
                    break;
                case "search": // New Feature
                    SearchForBook(library);
                    break;
                case "checkout": // New Feature (Borrowing)
                    CheckoutBook(library);
                    break;
                case "checkin": // New Feature
                    CheckinBook(library);
                    break;
                case "exit":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    // --- Existing Methods (Updated to use List<Book>) ---

    public static void AddBook(List<Book> library)
    {
        if (library.Count >= MaxCapacity)
        {
            Console.WriteLine("The library is full. No more books can be added.");
            return;
        }

        Console.WriteLine("Enter the title of the book to add:");
        string? newBookTitle = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(newBookTitle))
        {
            Console.WriteLine("Book title cannot be empty.");
            return;
        }

        // Create a new Book object and add it to the list.
        library.Add(new Book(newBookTitle));
        Console.WriteLine($"'{newBookTitle}' has been added successfully.");
    }

    public static void RemoveBook(List<Book> library)
    {
        if (!library.Any())
        {
            Console.WriteLine("The library is empty. No books to remove.");
            return;
        }

        Console.WriteLine("Enter the title of the book to remove:");
        string? titleToRemove = Console.ReadLine();
        Book? bookToRemove = FindBookByTitle(library, titleToRemove);

        if (bookToRemove != null)
        {
            library.Remove(bookToRemove);
            Console.WriteLine($"'{bookToRemove.Title}' has been removed successfully.");
        }
        else
        {
            Console.WriteLine("Book not found.");
        }
    }

    public static void DisplayBooks(List<Book> library)
    {
        Console.WriteLine("\n--- Current Books in Library ---");
        if (!library.Any())
        {
            Console.WriteLine("The library is currently empty.");
        }
        else
        {
            foreach (Book book in library)
            {
                // Display the book's title and its status.
                string status = book.IsCheckedOut ? "[Checked Out]" : "[Available]";
                Console.WriteLine($"- {book.Title} {status}");
            }
        }
        Console.WriteLine("------------------------------");
    }

    // --- New Feature Methods ---

    // 1. Add a Search Feature
    public static void SearchForBook(List<Book> library)
    {
        Console.WriteLine("Enter the title of the book to search for:");
        string? titleToSearch = Console.ReadLine();
        Book? foundBook = FindBookByTitle(library, titleToSearch);

        if (foundBook != null)
        {
            string status = foundBook.IsCheckedOut ? "Checked Out" : "Available";
            Console.WriteLine($"Success! '{foundBook.Title}' is in the collection. Status: {status}.");
        }
        else
        {
            Console.WriteLine("That book is not in the collection.");
        }
    }

    // 2. Limit Borrowing
    public static void CheckoutBook(List<Book> library)
    {
        // Use LINQ to count how many books are currently checked out.
        int currentlyBorrowed = library.Count(book => book.IsCheckedOut);
        if (currentlyBorrowed >= BorrowLimit)
        {
            Console.WriteLine("You have reached your borrow limit of 3 books.");
            return;
        }

        Console.WriteLine("Enter the title of the book to check out:");
        string? titleToCheckout = Console.ReadLine();
        Book? bookToCheckout = FindBookByTitle(library, titleToCheckout);

        if (bookToCheckout == null)
        {
            Console.WriteLine("That book does not exist in the library.");
        }
        else if (bookToCheckout.IsCheckedOut)
        {
            Console.WriteLine("That book is already checked out by someone.");
        }
        else
        {
            bookToCheckout.IsCheckedOut = true;
            Console.WriteLine($"You have successfully checked out '{bookToCheckout.Title}'.");
        }
    }

    // 3. Check-in a borrowed book
    public static void CheckinBook(List<Book> library)
    {
        Console.WriteLine("Enter the title of the book to check in:");
        string? titleToCheckin = Console.ReadLine();
        Book? bookToCheckin = FindBookByTitle(library, titleToCheckin);

        if (bookToCheckin == null)
        {
            Console.WriteLine("That book does not exist in the library.");
        }
        else if (!bookToCheckin.IsCheckedOut)
        {
            Console.WriteLine("That book was not checked out.");
        }
        else
        {
            bookToCheckin.IsCheckedOut = false;
            Console.WriteLine($"You have successfully checked in '{bookToCheckin.Title}'.");
        }
    }

    // --- Helper Method ---

    // A private helper method to avoid repeating the book-finding logic.
    private static Book? FindBookByTitle(List<Book> library, string? title)
    {
        if (string.IsNullOrWhiteSpace(title))
        {
            return null;
        }

        foreach (Book book in library)
        {
            if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                return book; // Return the found book object
            }
        }
        return null; // Return null if no book was found
    }
}