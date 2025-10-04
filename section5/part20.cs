using System;
using System.Collections;
using System.Collections.Generic;
public class StudentCollection : IEnumerable<string>
{
    string[] students = { "Aarav", "Diya", "Kavin", "Meera" };
    public IEnumerator<string> GetEnumerator()
    {
        foreach (var s in students)
        {
            yield return s; 
        }
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();  
    }
}
class Program
{
    static void Main()
    {
        var studentList = new StudentCollection();
        Console.WriteLine("Student Names:");
        foreach (var name in studentList)
        {
            Console.WriteLine(name);
        }
    }
}
