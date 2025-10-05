using System;

interface IStrategy { void Execute(); }

class Add : IStrategy { public void Execute() => Console.WriteLine("Addition Strategy"); }
class Subtract : IStrategy { public void Execute() => Console.WriteLine("Subtraction Strategy"); }

class Context
{
    IStrategy strategy;
    public void SetStrategy(IStrategy s) => strategy = s;
    public void DoWork() => strategy.Execute();
}

class Program
{
    static void Main()
    {
        Context c = new Context();

        c.SetStrategy(new Add());
        c.DoWork();

        c.SetStrategy(new Subtract());
        c.DoWork();
    }
}
