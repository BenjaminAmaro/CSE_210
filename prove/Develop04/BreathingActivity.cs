using System;

public class BreathingActivity : Activity
{
    private string _in;

    private string _out;

    public BreathingActivity (string activityName, string description, string breathin, string breathout) : base(activityName, description)
    {
        _in = breathin;
        _out = breathout;
    }
    

    public void Breathing()
    {
        Console.Clear();

        Console.WriteLine();

        int segundos = _duration;
        string BI = _in;
        string BO = _out;

        DateTime begin = DateTime.Now;
        DateTime finish = begin.AddSeconds(segundos);

        while(DateTime.Now < finish)
        {

            Console.Write(BI);
            for (int i =5; i> 0; i --)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.Write(BO);
            for (int i =5; i> 0; i --)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }
}