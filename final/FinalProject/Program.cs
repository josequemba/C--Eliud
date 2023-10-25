using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello FinalProject World!");
        int userInput = 0;

        ManagePortfolio manageportfolio = new ManagePortfolio ();

        while (userInput != 10)
        {
            Console.Clear ();
            manageportfolio.DisplayMenu ();
            Console.Write ("");
            userInput = int.Parse(Console.ReadLine ());

            if (userInput == 1)
            {
                manageportfolio.RequirementsSetter ();
            }

            else if (userInput == 2)
            {
                manageportfolio.ClassesSetterMenu ();
                Console.Write ("");
                int userInputClasse = int.Parse(Console.ReadLine ());
                manageportfolio.ClassesSetter (userInputClasse);
            }
            
            else if (userInput == 3)
            {
                manageportfolio.DisplayCurrentClasses ();
                Thread.Sleep (7000);
            }

            else if (userInput == 4)
            {
                manageportfolio.ReportGrade ();
            }
            
            else if (userInput == 5)
            {
                manageportfolio.BookSetter ();
            }
            
            else if (userInput == 6)
            {
                manageportfolio.WantBookSetter ();
            }
            
            else if (userInput == 7)
            {
                manageportfolio.TopicSetter ();
            }
            
            else if (userInput == 8)
            {
                manageportfolio.Save (); 
            }
            
            else if (userInput == 9)
            {
                manageportfolio.Load (); 
            }
        }
    }
}