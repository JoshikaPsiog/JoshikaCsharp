using System;
class ValueTypes
{
    public void Demo()
    {
        int a = 10;
        int b = a;
        b = 20;
        Console.WriteLine("Value Type example, a = " + a); // Output: 10 
    }
}
class ReferenceTypes
{
    public class Person
    {
        public string Name;
        public void Demo()
        {
            Person p1 = new Person();
            p1.Name = "Joshika";
            Person p2 = p1;
            p2.Name = "jaisree";
            Console.WriteLine("Reference Type example, p1.Name = " + p1.Name);
        }
    }
}
enum Days { Monday, Tuesday, Wednesday };
class EnumExample
{
    public void Demo()
    {
        Days today = Days.Tuesday;
        Console.WriteLine("Enum example, today = " + today);
        Console.WriteLine("Underlying int value = " + (int)today);
    }
}
class Program
{
    static void Main()
    {
        ValueTypes ex1 = new ValueTypes();
        ReferenceTypes.Person ex2 = new ReferenceTypes.Person();
        EnumExample ex3 = new EnumExample();
        ex1.Demo();
        ex2.Demo();
        ex3.Demo();
    }
}