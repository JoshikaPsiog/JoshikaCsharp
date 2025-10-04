using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main() 
    {
        Console.WriteLine("Fetching data...");

        string data = await Async(); 
        Console.WriteLine($"Received: {data}");

        Console.WriteLine("All done!");
    }
    static async Task<string> Async()
    {
        Console.WriteLine("Connecting to server...");
        await Task.Delay(2000); 
        Console.WriteLine("Processing data...");
        await Task.Delay(1500); 
        return "done";
    }
}
