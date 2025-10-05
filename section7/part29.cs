using System;
using System.Collections.Generic;

interface ISubscriber
{
    void Update(string message);
}
class Publisher
{
    private List<ISubscriber> subscribers = new List<ISubscriber>();

    public void Subscribe(ISubscriber sub)
    {
        subscribers.Add(sub);
        Console.WriteLine($"{sub.GetType().Name} subscribed!");
    }

    public void Unsubscribe(ISubscriber sub)
    {
        subscribers.Remove(sub);
        Console.WriteLine($"{sub.GetType().Name} unsubscribed!");
    }

    public void Notify(string message)
    {
        Console.WriteLine($"\n[Publisher]: {message}");
        foreach (var sub in subscribers)
        {
            sub.Update(message);
        }
    }
}
class EmailSubscriber : ISubscriber
{
    public void Update(string message)
    {
        Console.WriteLine($" Email Subscriber received update: {message}");
    }
}
class SMSSubscriber : ISubscriber
{
    public void Update(string message)
    {
        Console.WriteLine($" SMS Subscriber received update: {message}");
    }
}
class Program
{
    static void Main()
    {
        Publisher newsChannel = new Publisher();
        ISubscriber emailSub = new EmailSubscriber();
        ISubscriber smsSub = new SMSSubscriber();
        newsChannel.Subscribe(emailSub);
        newsChannel.Subscribe(smsSub);
        newsChannel.Notify("Breaking News: Design Patterns are fun!");
        newsChannel.Unsubscribe(emailSub);
        newsChannel.Notify("Update: Observer Pattern fully understood!");
    }
}
