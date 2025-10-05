using System;

class TV { 
    public void TurnOn() => Console.WriteLine("TV is ON"); 
}
class DVDPlayer {
    public void PlayMovie() => Console.WriteLine("DVD Player is playing movie");
}
class Speakers {
    public void SetVolume(int level) => Console.WriteLine($"Speakers volume set to {level}"); 
}
class OldProjector {
    public void StartProjection() => Console.WriteLine("Old Projector started projecting");
}

interface IDevice
{
    void Start();
}

class ProjectorAdapter : IDevice
{
    private OldProjector projector = new OldProjector();
    public void Start() => projector.StartProjection();
}
class HomeTheaterFacade
{
    private TV tv = new TV();
    private DVDPlayer dvd = new DVDPlayer();
    private Speakers speakers = new Speakers();
    private IDevice projector;
    public HomeTheaterFacade(IDevice projectorAdapter)
    {
        this.projector = projectorAdapter; 
    }
    public void WatchMovie()
    {
        Console.WriteLine("Preparing to watch a movie...");
        tv.TurnOn();
        speakers.SetVolume(20);
        dvd.PlayMovie();
        projector.Start(); 
        Console.WriteLine("Enjoy your movie! \n");
    }
}
class Program
{
    static void Main()
    {
        IDevice projectorAdapter = new ProjectorAdapter();
        HomeTheaterFacade homeTheater = new HomeTheaterFacade(projectorAdapter);
        homeTheater.WatchMovie();
    }
}
