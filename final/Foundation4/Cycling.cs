using System;
using System.Collections.Generic;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int length, double speed) : base(date, length, "Cycling")
    {
        _speed = speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetDistance()
    {
        double dist = _speed * base._length / 60;
        dist = Math.Round(dist, 2);
        return dist;
    }
}