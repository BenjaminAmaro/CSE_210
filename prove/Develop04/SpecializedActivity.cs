using System;

public class SpecializedActivity : Activity
{
    private string _in;

    private string _out;

    private string _hold;



    public SpecializedActivity (string activityName, string description, string breathin, string breathout, string hold) : base(activityName, description)
    {

        _in = breathin;
        _out = breathout;
        _hold = hold;
    }
    
    public void BreathingLow()
    {
        Console.Clear();

        Console.WriteLine();

        int segundos = _duration;
        string BI = _in;
        string BO = _out;
        string hold = _hold;

        DateTime begin = DateTime.Now;
        DateTime finish = begin.AddSeconds(segundos);

        while(DateTime.Now < finish)
        {

            Console.Write(BI);
            for (int i =4; i> 0; i --)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.Write(hold);
            for (int i =4; i> 0; i --)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.Write(BO);
            for (int i =4; i> 0; i --)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.Write(hold);
            for (int i =4; i> 0; i --)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }

        public void BreathingFocus()
    {
        Console.Clear();

        Console.WriteLine();

        int segundos = _duration;
        string BI = _in;
        string BO = _out;
        string hold = _hold;

        DateTime begin = DateTime.Now;
        DateTime finish = begin.AddSeconds(segundos);

        while(DateTime.Now < finish)
        {

            Console.Write(BI);
            for (int i =2; i> 0; i --)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(hold);
            for (int i =4; i> 0; i --)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(BO);
            for (int i =6; i> 0; i --)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(hold);
            for (int i =2; i> 0; i --)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }

    public void BreathingWakeUP()
    {
        Console.Clear();

        Console.WriteLine();

        int segundos = _duration;
        string BI = _in;
        string BO = _out;
        string hold = _hold;

        DateTime begin = DateTime.Now;
        DateTime finish = begin.AddSeconds(segundos);

        while(DateTime.Now < finish)
        {

            Console.Write(BI);
            for (int i =4; i> 0; i --)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(hold);
            for (int i =7; i> 0; i --)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.Write(BO);
            for (int i =8; i> 0; i --)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }
}