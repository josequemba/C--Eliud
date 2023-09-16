using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        int guessNumber = -111;

        //Console.Write("What is the magic number? ");
        //string userEntry = Console.ReadLine ();
        //int magicNumber = int.Parse (userEntry);

        Random randomGenerator = new Random ();
        int magicNumber = randomGenerator.Next (1, 100);

        while (magicNumber != guessNumber)
        {
            Console.Write("What is your guess?");
            string userEntry1 = Console.ReadLine ();
            guessNumber = int.Parse(userEntry1);

            if (magicNumber > guessNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guessNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
            
        }

    }
}