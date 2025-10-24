using System;

public class LibraryManager2
{
    public static void Run()
    {
        string book1 = "";
        string book2 = "";
        string book3 = "";
        string book4 = "";
        string book5 = "";

        while (true)
        {
            Console.WriteLine("\nWould you like to add, remove, display, or exit? (add/remove/display/exit)");
            // FIX #1: Make user input case-insensitive and handle potential nulls/whitespace.
            string? action = Console.ReadLine()?.ToLower().Trim();

            if (action == "add")
            {
                // FIX #2: Check if the library is full BEFORE asking for the book title.
                bool isFull = !string.IsNullOrEmpty(book1) &&
                              !string.IsNullOrEmpty(book2) &&
                              !string.IsNullOrEmpty(book3) &&
                              !string.IsNullOrEmpty(book4) &&
                              !string.IsNullOrEmpty(book5);

                if (isFull)
                {
                    Console.WriteLine("The library is full. No more books can be added.");
                    continue; // Skip the rest of the loop and prompt again.
                }

                Console.WriteLine("Enter the title of the book to add:");
                string? newBook = Console.ReadLine();

                // Also check if the user entered an empty title
                if (string.IsNullOrWhiteSpace(newBook))
                {
                    Console.WriteLine("Book title cannot be empty.");
                    continue;
                }

                if (string.IsNullOrEmpty(book1)) book1 = newBook;
                else if (string.IsNullOrEmpty(book2)) book2 = newBook;
                else if (string.IsNullOrEmpty(book3)) book3 = newBook;
                else if (string.IsNullOrEmpty(book4)) book4 = newBook;
                else if (string.IsNullOrEmpty(book5)) book5 = newBook;
                
                Console.WriteLine($"Book '{newBook}' added successfully.");
            }
            else if (action == "remove")
            {
                Console.WriteLine("Enter the title of the book to remove:");
                string? removeBook = Console.ReadLine();
                bool bookFound = false;

                // Make the book search case-insensitive for a better user experience.
                if (removeBook != null && removeBook.Equals(book1, StringComparison.OrdinalIgnoreCase)) { book1 = ""; bookFound = true; }
                else if (removeBook != null && removeBook.Equals(book2, StringComparison.OrdinalIgnoreCase)) { book2 = ""; bookFound = true; }
                else if (removeBook != null && removeBook.Equals(book3, StringComparison.OrdinalIgnoreCase)) { book3 = ""; bookFound = true; }
                else if (removeBook != null && removeBook.Equals(book4, StringComparison.OrdinalIgnoreCase)) { book4 = ""; bookFound = true; }
                else if (removeBook != null && removeBook.Equals(book5, StringComparison.OrdinalIgnoreCase)) { book5 = ""; bookFound = true; }

                if (bookFound)
                {
                    Console.WriteLine($"Book '{removeBook}' removed successfully.");
                }
                else
                {
                    Console.WriteLine("Book not found.");
                }
            }
            else if (action == "display")
            {
                // This entire block is new, based on the fixed display logic below.
                Console.WriteLine("\n--- Available Books ---");
                int bookCount = 0;

                // FIX #3: Only print the book if the variable is NOT empty.
                if (!string.IsNullOrEmpty(book1)) { Console.WriteLine($"- {book1}"); bookCount++; }
                if (!string.IsNullOrEmpty(book2)) { Console.WriteLine($"- {book2}"); bookCount++; }
                if (!string.IsNullOrEmpty(book3)) { Console.WriteLine($"- {book3}"); bookCount++; }
                if (!string.IsNullOrEmpty(book4)) { Console.WriteLine($"- {book4}"); bookCount++; }
                if (!string.IsNullOrEmpty(book5)) { Console.WriteLine($"- {book5}"); bookCount++; }

                if (bookCount == 0)
                {
                    Console.WriteLine("The library is empty.");
                }
                Console.WriteLine("-----------------------");
            }
            else if (action == "exit")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid action. Please try again.");
            }
        }
    }
}