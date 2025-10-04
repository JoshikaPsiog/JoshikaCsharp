using System;

public delegate void AlarmHandler();

class BaseAlarm
{
    public virtual AlarmHandler Ring { get; set; }

    public void Trigger()
    {
        Console.WriteLine("BaseAlarm: Triggering alarm...");
        Ring?.Invoke();
    }
}
class CustomAlarm : BaseAlarm
{
    public override AlarmHandler Ring { get; set; }
}
class Program
{
    static void BaseAlarmSound()
    {
        Console.WriteLine("Base Alarm Sound!");
    }

    static void CustomAlarmSound()
    {
        Console.WriteLine("Custom Alarm Sound!");
    }

    static void Main()
    {
        BaseAlarm baseAlarm = new BaseAlarm();
        baseAlarm.Ring = BaseAlarmSound;
        baseAlarm.Trigger();

        CustomAlarm customAlarm = new CustomAlarm();
        customAlarm.Ring = CustomAlarmSound; 
        customAlarm.Trigger();
    }
}
