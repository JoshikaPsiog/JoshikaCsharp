using System;

class Base
{
    public void methods(string print)
    {
        Console.WriteLine($"base says {print}");

    }
}
class derived :Base
{
    public new void methods(string print)
    {
        Console.WriteLine($"derived says{print}");
    }
}
class program
{
   
    public static void Main()
    {
        Base b1 = new Base();
        b1.methods("joshika");

        derived b2 = new derived();
        b2.methods("jaisree");

        Base b3 = new derived();
        b3.methods("congrats");
    }
}