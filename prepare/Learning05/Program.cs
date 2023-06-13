using System;

class Program
{
    static void Main(string[] args)
    {
        Square S1 = new Square();
        S1.SetColor("Black");
        S1.SetSide(4);

        Rectangle R1 = new Rectangle();
        R1.SetColor("Green");
        R1.SetLength(5);
        R1.SetWidth(10);

        Circle C1 = new Circle();
        C1.SetColor("Red");
        C1.SetRadius(30);

        // Display(S1);
        // Display(R1);
        // Display(C1);
        List<Shape> shapes1 = new List<Shape>();
        shapes1.Add(S1);
        shapes1.Add(R1);
        shapes1.Add(C1);

        foreach(Shape sh in shapes1)
        {
            double shape = sh.GetArea();
            Console.WriteLine($"{shape}");

        }

    }
    public static void Display(Shape shapes)
    {
        double area = shapes.GetArea();
        Console.WriteLine($" the area of the {shapes.GetColor()} is {area}");
    }
}