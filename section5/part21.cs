using System;
using System.Collections.Generic;
using System.Linq;
class Employee
{
    public string Name { get; set; }
    public string Dept { get; set; }
    public int Salary { get; set; }
}
class Program
{
    static void Main()
    {
        var employees = new List<Employee>
        {
            new Employee { Name="joshika", Dept="IT", Salary=60000 },
            new Employee { Name="jai", Dept="HR", Salary=45000 },
            new Employee { Name="sree", Dept="IT", Salary=55000 },
            new Employee { Name="subha", Dept="Sales", Salary=40000 }
            new Employee { Name="subha", Dept="Sales", Salary=40000 }
        };
        var highEarners = employees.Where(e => e.Salary > 50000);
        var grouped = employees.GroupBy(e => e.Dept);
        var ordered = employees.OrderByDescending(e => e.Salary);
        var names = employees.Select(e => e.Name);
        Console.WriteLine("High Earners:");
        foreach (var e in highEarners) Console.WriteLine(e.Name);
        Console.WriteLine("\nGrouped by Dept:");
        foreach (var g in grouped)
            Console.WriteLine($"{g.Key}: {string.Join(", ", g.Select(x => x.Name))}");
        Console.WriteLine("\nOrdered by Salary:");
        foreach (var e in ordered) Console.WriteLine($"{e.Name} - {e.Salary}");
        Console.WriteLine("\nEmployee Names:");
        Console.WriteLine(string.Join(", ", names));
    }
}
