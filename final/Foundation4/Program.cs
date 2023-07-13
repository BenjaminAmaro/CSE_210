using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Running running = new Running("13 Jul 2023", 30, 3.0);
        Cycling cycling = new Cycling("2 Jan 2023", 40, 40.0);
        Swimming swimming = new Swimming("25 Oct 2023", 35, 50);

        Console.WriteLine(running.GetSummary());
        Console.WriteLine(cycling.GetSummary());
        Console.WriteLine(swimming.GetSummary());
    }
}