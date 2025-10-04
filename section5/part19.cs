using System;
using System.Collections.Generic;
using System.Linq;
class Repository<T>
{
    private List<T> items = new List<T>();
    public void Add(T item) => items.Add(item);
    public void Update(int index, T item)
    {
        if (index >= 0 && index < items.Count)
            items[index] = item;
        else
            Console.WriteLine("Index out of range!");
    }
    public void Delete(T item) => items.Remove(item);
    public List<T> GetAll() => items.ToList();
}
class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
}
class Program
{
    static void Main()
    {
        Repository<Product> repo = new Repository<Product>();
        repo.Add(new Product { Id = 1, Name = "Laptop" });
        repo.Add(new Product { Id = 2, Name = "Mouse" });
        Console.WriteLine("All products:");
        foreach (var p in repo.GetAll())
            Console.WriteLine($"{p.Id} - {p.Name}");
        repo.Update(1, new Product { Id = 2, Name = "Wireless Mouse" });
        repo.Delete(new Product { Id = 1, Name = "Laptop" });
        Console.WriteLine("After update & delete:");
        foreach (var p in repo.GetAll())
            Console.WriteLine($"{p.Id} - {p.Name}");
    }
}
