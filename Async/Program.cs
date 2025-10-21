using System;
using System.Threading.Tasks;

class Program
{
    // This is the ONLY Main method in your entire project.
    public static async Task Main(string[] args)
    {
        // To run a lesson, just call its RunAsync method and await it.
        // To switch lessons, comment one out and uncomment another.

        await P4.RunAsync();

        Console.WriteLine("Execution complete. Press any key to exit.");
        Console.ReadKey();
    }
}