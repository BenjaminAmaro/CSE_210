using System;

public class ListingActivity : Activity
{
    private string _activityName;

    private string _description;


    private string _listingPrompt;

    private List<string> _userResponses = new List<string>();


    public ListingActivity (string activityName, string description) : base(activityName, description)
    {
        _activityName = activityName;
        _description = description;
    }
    
        public void ListingPrompt()
    {
        Random random1 = new Random();
        var list = new List<string>{ "Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"};
        int index = random1.Next(list.Count);
        _listingPrompt = list[index];
    }

        public void StartListing()
    {
        int segundos = _duration;

        int responseCount = 0;

        ListingPrompt();
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($"--- {_listingPrompt} ---");
        Console.WriteLine();

        Console.Write("you may begin in: ");
        
        for (int i =5; i> 0; i --)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        
        Console.WriteLine();

        DateTime begin = DateTime.Now;
        DateTime finish = begin.AddSeconds(segundos);

        while(DateTime.Now < finish)
        {   
            Console.Write("> ");
            string listing = Console.ReadLine();
            _userResponses.Add(listing);
            responseCount++;
        }
        
        Console.WriteLine($"You listed {responseCount} items! ");
    }

}
