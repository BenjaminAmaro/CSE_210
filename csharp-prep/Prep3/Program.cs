using System;

class Program
{
    static void Main(string[] args)
    {   
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        Console.WriteLine(magicNumber);

        int guess = -1;

        while ( magicNumber != guess)
        { 
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());


            if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }

    }
}