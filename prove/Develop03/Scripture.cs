using System;
using System.Collections.Generic;



public class Scripture
{
    private string[] _oneScripture = new string[] {"John ","3:","16","For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."};

    private string[] _multiSpcripture = new string[] {"Proverbs ","3:","5","6","“Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths. "};

    private string _verse;

    private string _citation;

    public Scripture()
    {
        _verse = VersePicker();
    }

    private string VersePicker()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, 5);
        if (number < 3 )
        {
            Reference citation = new Reference(_oneScripture[0], _oneScripture[1], _oneScripture[2]);
            _citation = citation.GetCompleteCitation();
            string verse = _oneScripture[3];
            return verse;
        }

        else
        {
            Reference citation = new Reference (_multiSpcripture[0], _multiSpcripture[1], _multiSpcripture[2], _multiSpcripture[3]);
            _citation = citation.GetCompleteCitation();
            string verse = _multiSpcripture[4];
            return verse;
        }

        
        
    }

    public string GetVerse()
    {
        return _verse;
    }

    public string GetCitation()
    {
        return _citation;
    }
    
    
}