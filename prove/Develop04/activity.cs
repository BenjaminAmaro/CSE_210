using System;

public class Activity
{
    private string _activityName;

    private string _description;

    protected int _duration;

    public Activity (string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }

    
    public void GetInfoStart()
    {
        Console.WriteLine($"Welcome to the {_activityName} activity,");
        Console.WriteLine();
        Console.WriteLine($"{_description}");    
    }

    public void SetDuration()
    {
        Console.Write("How long, in seconds, would you like for your sesion? ");
        string durationstring = Console.ReadLine();
        int duration = int.Parse(durationstring);
        _duration = duration;
        Console.Clear();
    }

    public void GetInfoEnd()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Well done!! ");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName} activity.");
    }
    public void MethodSpin()
    {
        List<string> animation = new List<string>();

        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");

        foreach (string a in animation)
        {
            Console.Write(a);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}