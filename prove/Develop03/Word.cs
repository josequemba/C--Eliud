using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

class Word
{
    private string _text;
    private string _patternShown;
    private bool _isHidden;

    public Word ()
    {
        _text = "empty";
    }

    public Word (string text)
    {
        _text = text;
    }

    public void Hide ()
    {
        string[] words = _text.Split (" ");
            
        int wordInt = words.Count ();

        string userE = "";
        int times = 0;

        while (userE != "quit")
        {
            Random randomGenerator = new Random ();
            int random = randomGenerator.Next (0, wordInt);

            int wordLen = words[random].Length;

            string oneLine = "";

            string underScores = "_";

            string underS = "";

            for (int i = 0; i < wordLen; i++)
            {
                underS += $"{underScores[0]}";
            } 

            _patternShown = Regex.Escape(words[random]);
            //Console.WriteLine(_patternShown);
            //words[random] = underS;

            for (int i = 0; i < wordInt; i++)
            {
                oneLine += $" {words[i]}";
                string hiddenText = Regex.Replace(oneLine, _patternShown, words[random] = underS);
            } 

            Console.WriteLine(oneLine);

            Console.WriteLine("");

            Console.WriteLine("Press enter to continue or type 'quit' to finish");

            userE = Console.ReadLine();
            
            Console.Clear();
            
            times ++;
        }
    }

    public void Show ()
    {
        Console.WriteLine(_patternShown);
    }

    public string GetHiddenWords ()
    {
        return _patternShown;
    }

    public bool IsHidden ()
    {
        string[] words = _text.Split (" ");
        int wordInt = words.Count ();

        bool containsWord;
        
        containsWord = words.Contains(_patternShown);
        
        if (containsWord)
        {
            return true;
        }
        else
        {
            return false;   
        }
    }

    public string GetDisplayText ()
    {
        string words = _text;
        return words;
    }
}