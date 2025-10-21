public class Program
{
    public async Task DownloadDataAsync()
    {
        try
        {
            Console.WriteLine("Starting data download...");
            await Task.Delay(2000); // Simulate a delay for downloading data
            throw new Exception("Network error occurred.");
            Console.WriteLine("Data downloaded successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    public async Task DownloadDataAsync2()
    {
        Console.WriteLine("Starting second data download...");
        await Task.Delay(3000); // Simulate a longer delay for downloading data
        Console.WriteLine("Second data downloaded successfully.");
    }

    public static async Task Main(string[] args)
    {
        Task.WhenAll(
            new Program().DownloadDataAsync(),
            new Program().DownloadDataAsync2()
        ).Wait();
    }
}