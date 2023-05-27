using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        Scripture quotable = new Scripture();
        Display writeVerse = new Display();
        Word blankwords = new Word(quotable.GetCitation(), quotable.GetVerse());
        writeVerse.OutputOne(quotable.GetCitation(),quotable.GetVerse());

        bool _runApp = true;

        while(_runApp)
        {
            Console.Write("Press ENTER to continue or type 'quit' to finish. ");
            string input = Console.ReadLine();
            if (input == "")
            {
                blankwords.WordBlanker();
                string scripture = blankwords.ScriptureGetter();
                writeVerse.OutputTwo(scripture);
                _runApp = blankwords.DoneYet();

                if (!_runApp)
                {
                    Console.WriteLine("Thanks for using the memorizer");
                }
                
            }

            else if (input == "quit")
            {
                _runApp = false;
            }

            else
            {
                Console.WriteLine("Invalid Selection, please try 'quit' or 'Enter'. ");
                continue;
            }
        }
    }
}