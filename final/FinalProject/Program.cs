using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello FinalProject World!");
        int userInput = 0;

        ManagePortfolio manageportfolio = new ManagePortfolio ();
 

        while (userInput != 7)
        {
            Console.Clear ();
            manageportfolio.DisplayMenu ();
            Console.Write ("");
            userInput = int.Parse(Console.ReadLine ());
        }
    }
}