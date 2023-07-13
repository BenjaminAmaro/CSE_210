using System;
using System.Collections.Generic;

public class Running : Activity
{
    private double _distance;

    public Running(string date, int length, double distance) : base(date, length, "Running")
    {
        _distance = distance;
    }

    public override double GetSpeed()
    {
        return (_distance / base._length) * 60;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetPace()
    {
        return _length / _distance;
    }
}
