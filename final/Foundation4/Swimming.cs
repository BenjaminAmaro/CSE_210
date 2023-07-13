using System;
using System.Collections.Generic;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int length, int laps) : base(date, length, "Swimming")
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        double dist = _laps * 50 / 1000 * 0.62;
        dist = Math.Round(dist, 2);
        return dist;
    }

    public override double GetSpeed()
    {
        double speed = (GetDistance() / base._length) * 60;
        speed = Math.Round(speed, 2);
        return speed;
    }

    public override double GetPace()
    {
        double pace = base._length / GetDistance();
        pace = Math.Round(pace, 2);
        return pace;
    }
}
