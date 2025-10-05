using System;
using System.Threading;
using System.Threading.Tasks;
public sealed class Logger
{
    private static readonly Logger _instance = new Logger();
    private Logger()
    {
        Console.WriteLine("Logger instance created (only once)");
    }
    public static Logger Instance => _instance;
    public void Log(string message)
    {
        Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} {message}");
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Starting Threads");
        Thread[] threads = new Thread[5];
        for (int i = 0; i < 5; i++)
        {
            threads[i] = new Thread(() =>
            {
                Logger.Instance.Log("Logging from Thread");
            });
            threads[i].Start();
        }
        foreach (var t in threads) t.Join();
        Console.WriteLine("\nStarting Tasks");
        Task[] tasks = new Task[5];
        for (int i = 0; i < 5; i++)
        {
            tasks[i] = Task.Run(() =>
            {
                Logger.Instance.Log("Logging from Task");
            });
        }
        Task.WaitAll(tasks);
        Console.WriteLine("\nAll threads/tasks completed");
    }
}