using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        
        PromptGenerator prompt = new PromptGenerator ();
        Journal journal = new Journal ();
        Menu menu1 = new Menu ();
        LuchyPhases luchyPhases = new LuchyPhases ();
                       
        Console.WriteLine ();
        

        Console.Write("Please enter your name: ");
        string nameUser = Console.ReadLine();

        luchyPhases._nameOfUser = nameUser;

        int action = 0;
      
        while (action != 6)
        {
            menu1.DisplayMenu();

            Console.Write("What would you like to do? ");
            action = int.Parse(Console.ReadLine());
            
            string phraseP = luchyPhases.RandomPhraser();

            if (action == 1)
            {
                string random = prompt.GetRandomPrompt();
                Console.WriteLine(random);
                string response = Console.ReadLine();
                
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                
                Entry entry1 = new Entry ();
                entry1._date = dateText;
                entry1._promptText = random;
                entry1._entryText = response;
                entry1._luchyPrase = phraseP;

                //to add string for the file
                string valuet = ($"Date: {dateText} - Prompt: {random} \n{response} \nLucky Phrase: {phraseP}\n");
                journal._toString.Add(valuet);

                journal.AddEntry(entry1);
            }

            else if(action == 2)
            {
                journal.DisplayAll();
            }

            else if(action == 3)
            {
                Console.WriteLine("What is the Filename?");
                string fileName = Console.ReadLine();

                journal.LoadFromFile($"{fileName}");
            }

            else if(action == 4)
            {
                Console.WriteLine("What is the Filename?");
                string fileName1 = Console.ReadLine();

                journal.SaveToFile($"{fileName1}");
                Console.WriteLine();
            }
            
            else if(action == 5)
            {
                Console.WriteLine($"\n{phraseP}\n");
            } 
        }

    }

}   