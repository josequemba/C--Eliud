using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop03 World!");
        Console.WriteLine("");

        Reference reference1 = new Reference ();

        string refer2 = reference1.GetDisplayText();

        Scripture scripture1 = new Scripture(reference1, "And it came to pass that when they had gathered themselves together that he aspake unto them in this wise, saying: O ye, my people, lift up your heads and be comforted; for behold, the time is at hand, or is not far distant, when we shall no longer be in subjection to our enemies, notwithstanding our many strugglings, which have been in vain; yet I trust there bremaineth an effectual struggle to be made.");

        Word word = new Word ();
        
        string stopNow = "";

        while (stopNow != "quit")
        {
            Console.WriteLine(scripture1.GetDisplayText());
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            Console.ReadLine();
            Console.Clear();
            scripture1.HideRandomWords(1);
       
            stopNow = "quit";
        }

        scripture1.IsCompletelyHidden();
   
        
        

    }
}