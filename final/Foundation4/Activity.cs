using System;
using System.Collections.Generic;

public abstract class Activity
{
    private string _date;
    protected int _length;
    protected string _activityName;

    public Activity(string date, int length, string activityName)
    {
        _date = date;
        _length = length;
        _activityName = activityName;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();

        string summary = $"{_date} {_activityName} ({_length} min) - Distance: {distance} miles, Speed: {speed} mph, Pace: {pace} min/mile";
        return summary;
    }
}
