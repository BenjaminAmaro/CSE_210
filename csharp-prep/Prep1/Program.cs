using System;

class Program
{
    static void Main(string[] args)
    {
    Console.WriteLine("Hello Prep1 World!");
    int x = 10;
    int y = 5;
    if (x > y)
        {
            Console.WriteLine("what is your First name? ");
            string fname = Console.ReadLine();

            Console.WriteLine("what is your Lastname? ");
            string lname = Console.ReadLine();
            
            Console.WriteLine($"your name is {lname}, {fname} {lname}. " );
        }
    }
}