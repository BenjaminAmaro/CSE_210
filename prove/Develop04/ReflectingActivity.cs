using System;

public class ReflectingActivty : Activity
{
    private string _prompt;

    public ReflectingActivty (string activityName, string description) : base(activityName, description)
    {

    }

    public void prompt()
    {
        Random random1 = new Random();
        var list = new List<string>{ "Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.","Think of a time when you helped someone in need.","Think of a time when you did something truly selfless."};
        int index = random1.Next(list.Count);
        _prompt = list[index];
    }
    
    public void StartReflect()
    {   
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        Console.WriteLine($"--- {_prompt} ---");
        Console.WriteLine();

        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("you may begin in: ");
        
        for (int i =5; i> 0; i --)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }


    }
    

    public void ReflectingPrompts()
    {

        Console.Clear();

        Console.WriteLine();

        int segundos = _duration;

        DateTime begin = DateTime.Now;
        DateTime finish = begin.AddSeconds(segundos);

        while(DateTime.Now < finish)
        {   
            var random = new Random();
            var list = new List<string>{ "Why was this experience meaningful to you? ","Have you ever done anything like this before? ","How did you get started? ","How did you feel when it was complete?", "What made this time different than other times when you were not as successful? ", "What is your favorite thing about this experience?",  "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};
            int index = random.Next(list.Count);
            string question = list[index];
        
            Console.WriteLine();
            Console.Write($"> {question}");
            MethodSpin();
        }
    }
}
