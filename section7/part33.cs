using System;
using System.Threading;
using System.Threading.Tasks;
class Program
{
    static void ThreadMethod(object id)
    {
        Console.WriteLine($"Thread {id} started");
        Thread.Sleep(1000);
        Console.WriteLine($"Thread {id} finished");
    }
    static void TaskMethod(int id)
    {
        Console.WriteLine($"Task {id} started");
        Thread.Sleep(1000); 
        Console.WriteLine($"Task {id} finished");
    }
    static void Main()
    {
        Console.WriteLine("=== Using Threads ===");
        Thread[] threads = new Thread[3];
        for (int i = 0; i < 3; i++)
        {
            threads[i] = new Thread(ThreadMethod);
            threads[i].Start(i + 1);
        }
        foreach (var t in threads) t.Join(); 
        Console.WriteLine("\n=== Using Tasks (TPL) ===");
        Task[] tasks = new Task[3];
        for (int i = 0; i < 3; i++)
        {
            int id = i + 1;
            tasks[i] = Task.Run(() => TaskMethod(id));
        }
        Task.WaitAll(tasks); 
        Console.WriteLine("\nAll threads and tasks completed");
    }
}
