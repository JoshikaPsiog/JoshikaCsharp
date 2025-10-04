using System;

public delegate void AlarmHandler();

class AlarmClock
{
    public event AlarmHandler Ring;
    public void StartAlarm()
    {
        Console.WriteLine(" Alarm time reached!");
        Ring?.Invoke();  
    }
}
class Program
{
    static void ShowWakeMessage()
    {
        Console.WriteLine(" Wake up! Time to get ready!");
    }
    static void PlayMusic()
    {
        Console.WriteLine(" Playing morning playlist...");
    }
    static void Main()
    {
        AlarmClock clock = new AlarmClock();

        clock.Ring += ShowWakeMessage;
        clock.Ring += PlayMusic;
        clock.StartAlarm();
    }
}
