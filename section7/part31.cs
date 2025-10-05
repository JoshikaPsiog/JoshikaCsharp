using System;
using System.Collections.Generic;
class User { public int Id; public string Name; }


interface IUserRepository
{
    void Add(User user);
    IEnumerable<User> GetAll();
}
class UserRepository : IUserRepository
{
    private List<User> users = new List<User>();
    public void Add(User user) => users.Add(user);
    public IEnumerable<User> GetAll() => users;
}
interface IUnitOfWork
{
    IUserRepository Users { get; }
    void Commit();
}
class UnitOfWork : IUnitOfWork
{
    public IUserRepository Users { get; } = new UserRepository();

    public void Commit()
    {
        Console.WriteLine("All changes committed!");
    }
}

class Program
{
    static void Main()
    {
        IUnitOfWork uow = new UnitOfWork();

        uow.Users.Add(new User { Id = 1, Name = "Alice" });
        uow.Users.Add(new User { Id = 2, Name = "Bob" });

        uow.Commit();
        Console.WriteLine("Users in DB:");
        foreach (var user in uow.Users.GetAll())
            Console.WriteLine($"Id: {user.Id}, Name: {user.Name}");
    }
}
