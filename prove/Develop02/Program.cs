using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Console.WriteLine("Welcome to the Journal Program");
        int choice;
        do
        {

    Console.WriteLine("Please Select one of the following choices: ");
    Console.WriteLine("1. Write ");
    Console.WriteLine("2. Display ");
    Console.WriteLine("3. Load ");
    Console.WriteLine("4. Save ");
    Console.WriteLine("5. Quit ");
    Console.Write("What Would you like to do?: ");
    choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {


        case 1:


            string _prompt = journal.prompts();
            Console.WriteLine("");
            Console.Write(_prompt);
            journal._Prompt = _prompt;
            journal._EntryText = Console.ReadLine();
            Console.WriteLine("");  
            Console.Write("What is your mood today?: ");  
            journal._Mood = Console.ReadLine();
            journal._Date = journal.timeEntry();
            journal.Write();

            break;



        case 2:
            journal.Display();

            break;



        case 3:
            FileJournal.readFromFile();
            break;



        case 4:
            Console.WriteLine("Saving journal entries to CSV file...");
            FileJournal.SaveToCsv(journal.journallist);
            Console.WriteLine("Journal entries saved to journal_entries.csv.");
            break;



        case 5:
            Console.WriteLine("Thank you bye! ");
            break;


        
        default:
            Console.WriteLine("Invalid Choice ");
            break;
    }
        }while (choice!= 5);
    }

    
}