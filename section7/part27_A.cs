using System;
using System.Threading;

class Logger
{
    private static Logger instance = null;
    private static readonly object lockObj = new object();
    private Logger()
    {
        Console.WriteLine("Logger instance created!");
    }
    public static Logger GetInstance()
    {
        lock (lockObj)
        {
            if (instance == null)
                instance = new Logger();
            return instance;
        }
    }
    public void Log(string message)
    {
        Console.WriteLine($"[LOG]: {message}");
    }
}
class Program
{
    static void Main()
    {
        Thread t1 = new Thread(() =>
        {
            Logger logger1 = Logger.GetInstance();
            logger1.Log("Thread 1 logging message.");
        });
        Thread t2 = new Thread(() =>
        {
            Logger logger2 = Logger.GetInstance();
            logger2.Log("Thread 2 logging message.");
        });
        t1.Start();
        t2.Start();
        t1.Join();
        t2.Join();

        Console.WriteLine("Both threads used the same Logger instance ");
    }
}
