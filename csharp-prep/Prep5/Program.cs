using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        Console.WriteLine();

        DisplayWelcome ();

        string nameOfUser = PromptUserName ();

        int favoriteNumber =  PromptUserNumber ();

        int squaredNumber = SquareNumber (favoriteNumber);

        DisplayResult (nameOfUser, squaredNumber);


    //DisplayWelcome - Displays the message, "Welcome to the Program!"
    static void DisplayWelcome ()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    //PromptUserName - Asks for and returns the user's name (as a string)
    static string PromptUserName ()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine ();

        return name;
    }
    
    //PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
    static int PromptUserNumber ()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine ());

        return number;    
    }

    //SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
    static int SquareNumber (int numPromplted)
    {
        int squared = numPromplted * numPromplted;

        return squared;
    }

    //DisplayResult - Accepts the user's name and the squared number and displays them.
    static void DisplayResult (string userNames, int squaredNumbers)
    {
        Console.WriteLine ($"{userNames}, the square of your number is {squaredNumbers}");
    }
    }
}