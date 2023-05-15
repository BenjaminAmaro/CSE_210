using System;
using System.Collections.Generic;
using System.IO;


public static class FileJournal
{
    public static void SaveToCsv(List<Journal> journallist)
    {   
        Console.WriteLine("Saving to File... ");
        string fileName = "journal_entries.csv";
        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            foreach (Journal entry in journallist)
            {
                outputFile.WriteLine(entry._Writemyday);
            }
        }
    }
    public static List<Journal> readFromFile()
    {
        Console.WriteLine("Reading list from file... ");
        List<Journal> entry = new List<Journal>();
        string fileName = "journal_entries.csv";

        string[] lines = System.IO.File.ReadAllLines(fileName);
        
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

        return entry;
    }
}
