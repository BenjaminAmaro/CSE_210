using System;

public class Rectangle : Shape
{
    private double _lenght;
    private double _width;

    public double GetLength()
    {
        return _lenght;
    }
    public double GetWitdth()
    {
        return _width;
    }

    public void SetLength(double lenght)
    {
        _lenght = lenght;
    }
    public void SetWidth(double width)
    {
        _width = width;
    }
    

    public override double GetArea()
    {
        return _lenght * _width;
    }
}