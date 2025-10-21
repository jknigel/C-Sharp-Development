public class P4
{
    public async Task PerformLongOperationAsync()
    {
        try
        {
            Console.WriteLine("Starting long operation...");
            await Task.Delay(3000);
            throw new Exception("An error occurred during the long operation.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    public static async Task RunAsync()
    {
        P4 program = new P4();
        await program.PerformLongOperationAsync();
    }
}
