using System;
using System.Collections.Generic;


public class Word
{
    private List<int> _used = new List<int>();

    private string[] _progress = new string[] {};

    private int _wordCount;

    private bool _status = true;

    private string _citation;

    private string _verse;

    public Word(string citation, string verse)
    {
        _verse = verse;
        BuildArray(verse);
        _citation= citation;
    }

    public void BuildArray(string verse)
    {
        _progress = verse.Split(' ');
        _wordCount = _progress.Length;
    }
    
    public void WordBlanker()
    {
        Random randomGenerator = new Random();
        bool loopAgain = true;
        int iterator = 0;
        while (loopAgain)
        {
            int number = randomGenerator.Next(0, _wordCount);
            if (_used.Contains(number))
            {
                continue;
            }

            else
            {
                iterator ++;
                _used.Add(number);
                string blankword = _progress[number];
                foreach (char i in blankword)
                {
                    blankword = blankword.Replace(i, '_');
                }
                _progress[number] = blankword;
                if (_wordCount == _used.Count)
                {
                    loopAgain = false;
                    _status = false;
                    break;
                }
            if (iterator == 3)
            {
                loopAgain = false;
            }
            }
        }
    }
    public string ScriptureGetter()
    {
        _verse = string.Join(' ', _progress);
        string scripture = ($"{_citation}  {_verse}");
        return scripture;
    }

    public bool DoneYet()
    {
        return _status;
    }
}