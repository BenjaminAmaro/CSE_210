using System;
using System.Collections.Generic;

public class Journal
{   
    public List<Journal>journallist = new List<Journal>();

    public string _EntryText;

    public string _Prompt;
    public string _Date;
    public string _Writemyday;
    public string _Mood;

    public string prompts()
    {
        var random = new Random();
        var list = new List<string>{ "Who was the most interesting person I interacted with today? ","What was the best part of my day? ","How did I see the hand of the Lord in my life today? ","What was the strongest emotion I felt today? ", "f I had one thing I could do over today what would it be? "};
        int index = random.Next(list.Count);
        return list[index];
    }
    
    public string timeEntry()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        return dateText;
    }

    public void Write()
    {
        Journal journal = new Journal();
        journal._Writemyday = $"Today is: {_Date}, Prompt: {_Prompt}, Answer: {_EntryText}, Mood: {_Mood}";

        journallist.Add(journal);
    }

    public void Display()
    {
        Console.WriteLine("the entry of today is: ");
        foreach(Journal i in journallist)
        {
            Console.WriteLine(i._Writemyday);
        }
        
    }

}
