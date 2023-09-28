using System;
using System.Collections.Generic;
using System.ComponentModel;

public class WordDisplayer
{
    private string _words;
    
    public WordDisplayer ()
    {
    }

    public WordDisplayer (string container)
    {
        _words = container;
    }

    public void ListOfWords ()
    {
        string[] wordList = _words.Split (" ");
        
        int wordInt = wordList.Count ();

        for (int i = 0; i < wordInt; i++)
            {
                string oneLine = $" {wordList[i]}";
                Console.WriteLine(oneLine);
            } 

    }
}