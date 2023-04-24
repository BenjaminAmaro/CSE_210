using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int total = 0;
        int biggest = -99999999;
        int enterNumber = -1;
        List<int> numbers = new List<int>();

        while (enterNumber != 0 )
        {

        Console.Write("What is your guess? ");
        enterNumber = int.Parse(Console.ReadLine());
        if (enterNumber != 0)
        {
            numbers.Add(enterNumber);
        }
        }

        foreach (int number in numbers)
        {
            total += number;
        }

        Console.WriteLine($"The sum is: {total}");

        float average = ((float)total) / numbers.Count;
        Console.WriteLine($"The average is: {average}");


        foreach (int value in numbers)
        {
            if (value > biggest)
            {
                biggest = value;
            }
        }
        Console.WriteLine($"The largest number is:  {biggest}");

    }
}