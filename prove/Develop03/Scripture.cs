using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Linq;

public class Scripture
{
    private Reference _references;
    private List<Word> _words = new List<Word>();
    private string _quitV;
    private string _text; 
    private string _wordHidden;
    private List<int> GenerateRandomNonRepeatingNumbers(int min, int max)
    {
        List<int> numbers = Enumerable.Range(min, max - min + 1).ToList();
        Random random = new Random();

        // Shuffle the list using the Fisher-Yates shuffle algorithm
        for (int i = numbers.Count - 1; i > 0; i--)
        {
            int j = random.Next(0, i + 1);
            int temp = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = temp;
        }

        return numbers;
    }

    Reference reference1 = new Reference ("Mosiah", 7, 18);
    
    public Scripture (Reference reference, string text)
    {
        _references = reference;
        _text = text;
    }

    public string GetWordHidden ()
    {
        return _wordHidden;
    }
    
    public void HideRandomWords (int numberToHide)
    {
        WordDisplayer wordDisplayer = new WordDisplayer (_text);
        Word word = new Word (_text);
        string refer2 = reference1.GetDisplayText();
 
        string[] words = _text.Split (" ");
            
        int wordInt = words.Count ();

        //string userE = "";

        while (_quitV != "quit")
        {
            //Random randomGenerator = new Random ();
            //int random = randomGenerator.Next (0, wordInt);

            int random = 0;

            List<int> numbers = GenerateRandomNonRepeatingNumbers(0, wordInt-1);

            foreach (int number in numbers)
            {
                random = number;
                ///////////////////////////////////////
                
                int wordLen = words[random].Length;

                string oneLine = "";

                string underScores = "_";

                string underS = "";

                for (int i = 0; i < wordLen; i++)
                {
                    underS += $"{underScores[0]}";
                } 

                _wordHidden= Regex.Escape(words[random]);

                for (int i = 0; i < wordInt; i++)
                {
                    oneLine += $" {words[i]}";
                    string hiddenText = Regex.Replace(oneLine, _wordHidden, words[random] = underS);
                } 
            
                Console.WriteLine(refer2 + oneLine);

                Console.WriteLine("");

                Console.WriteLine("Press enter to continue, type 'quit' to finish and type 'words' to see the list of words.");
            
                _quitV = Console.ReadLine();

                Console.Clear();
                                
                if (_quitV == "quit")
                {
                    Console.WriteLine("Thanks for your Effort");
                    break;
                }
                else if (_quitV == "words")
                {
                    wordDisplayer.ListOfWords();
                    break;
                }
            }
            _quitV = "quit";
        }
    }

    public string GetDisplayText ()
    {
        string refer2 = reference1.GetDisplayText();

        string text1 = $"{refer2} {_text}".ToString();
        return text1;
    }

    public bool IsCompletelyHidden ()
    {
        if (_quitV == "quit")
        {
            return true;
        }
        else
        {
            return false;
        }
        //string listOne = "";
        //string listTwo = "";

        //List<string> wordList1 = _text.Split(" ").ToList();
        //List<string> wordList2 = new List<string>();

        //string itW = new string(_wordHidden[0], 1);
        //Console.WriteLine (itW);
   
        //wordList2.Add(_wordHidden);
        //
        //foreach (string word1 in wordList1)
        //{
        //    listOne = word1;
        //    Console.WriteLine(word1);
        //}
        //
        //foreach (string word2 in wordList2)
        //{
        //    listTwo = word2;
        //    Console.WriteLine(word2);
        //}

        ////Console.WriteLine(wordList1);
        ////Console.WriteLine(wordList2);
        //bool areEqual = wordList1.Equals(wordList2);
        //if (areEqual)
        //{
        //    Console.WriteLine("Both lists have the same words.");
        //}
        //else
        //{
        //    Console.WriteLine("The lists do not have the same words.");
        //}
    }
}