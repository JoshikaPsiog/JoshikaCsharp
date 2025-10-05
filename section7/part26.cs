using System;
class robo
{
    private static robo instance = null;
    private robo()
    {
        Console.WriteLine("Singleton object created!");
    }
    public static robo GetInstance()
    {
        if (instance == null)
        { 
            instance = new robo();
        }
        return instance;
    }
    public void Display()
    {
        Console.WriteLine("Hello, I’m the only Singleton instance!");
    }
}
class Program
{
    static void Main()
    {
        robo obj1 = robo.GetInstance();
        robo obj2 = robo.GetInstance();
        obj1.Display();
        if (obj1 == obj2)
            Console.WriteLine("Both references point to the same object");
        else
            Console.WriteLine("Different objects");
    }
}
