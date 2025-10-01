using System;
class Person
{
    public string Name;           
    private int Age;              
    protected double Salary;      
    internal string Department;  

    public Person(string name, int age, double salary, string dept)
    {
        Name = name;
        Age = age;
        Salary = salary;
        Department = dept;
    }

    public void ShowPrivate()
    {
        Console.WriteLine($"Age (private): {Age}"); // Can access private inside class
    }
}
class Employee : Person
{
    public Employee(string name, int age, double salary, string dept)
        : base(name, age, salary, dept) { }

    public void ShowProtected()
    {
        Console.WriteLine($"Salary (protected): {Salary}"); // Accessible in derived class
    }
}

class Program
{
    static void Main()
    {
        Person p = new Person("Joshika", 25, 50000, "ECE");
        Console.WriteLine($"Name (public): {p.Name}");        
        // Console.WriteLine($"Age: {p.Age}");              Error: private
        Console.WriteLine($"Department (internal): {p.Department}"); 
        p.ShowPrivate();                                     

        Employee e = new Employee("Jaisree", 28, 60000, "CSE");
        e.ShowProtected();                                    
    }
}
