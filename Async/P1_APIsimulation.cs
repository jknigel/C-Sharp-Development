// In your P1.cs file

using System;
using System.Threading.Tasks;

// The class name can be whatever you want, e.g., Program1, P1, Lesson1
public class P1 
{
    // These are the methods specific to this lesson's logic
    public async Task DownloadDataAsync()
    {
        try
        {
            Console.WriteLine("Starting data download...");
            await Task.Delay(2000);
            throw new Exception("Network error occurred.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    public async Task DownloadDataAsync2()
    {
        Console.WriteLine("Starting second data download...");
        await Task.Delay(3000);
        Console.WriteLine("Second data downloaded successfully.");
    }

    // *** THIS IS THE KEY CHANGE ***
    // Renamed 'Main' to a callable method like 'RunAsync'.
    // It is now the "entry point" for THIS LESSON's logic, not the whole program.
    public static async Task RunAsync()
    {
        Console.WriteLine("--- Running Lesson P1 ---");
        try
        {
            // Note: We use 'await' here instead of '.Wait()'
            // This is the modern, safe way to handle async tasks.
            await Task.WhenAll(
                new P1().DownloadDataAsync(),
                new P1().DownloadDataAsync2()
            );
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nOne of the tasks failed: {ex.Message}");
        }
        Console.WriteLine("--- Lesson P1 Finished ---\n");
    }
}