using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Starting long process...");

        // Start the long process asynchronously
        await LongProcessAsync();

        Console.WriteLine("Long process finished.");
    }

    static async Task LongProcessAsync()
    {
        // Simulate a long process by waiting for 5 seconds
        await Task.Delay(9000);
    }
}
