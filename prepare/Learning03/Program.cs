using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Console.WriteLine("");

        //Fraction fraction1 = new Fraction ();
        //Fraction fraction2 = new Fraction (6);
        //Fraction fraction3 = new Fraction (6, 7);
        Fraction fraction4 = new Fraction ();
        Console.WriteLine("");

        //creating fractions
        //Console.WriteLine(fraction1.GetFractionString ());
        //Console.WriteLine(fraction2.GetFractionString ());
        //Console.WriteLine(fraction3.GetFractionString ());

        Console.WriteLine("Elaborate your own fraction:");
        Console.WriteLine("");

        Console.Write("Enter any fraction (x/y) or (x): ");
        string userInput = Console.ReadLine();
        int nountSt = userInput.Count ();

        if (nountSt == 1)
        {
            char userI = userInput[0];
            double userId = char.GetNumericValue(userI);
            int userIi = (int)userId;

            fraction4.SetTop(userIi);
            Console.WriteLine(fraction4.GetFractionString ());
            Console.WriteLine(fraction4.GetDecimalValue ());
            //Console.WriteLine(userI);
        }
        else if (nountSt == 3)
        {
            char userI1 = userInput[0];
            double userI1d = char.GetNumericValue(userI1);
            int userI1i = (int)userI1d;

            char userI2 = userInput[2];
            double userI2d = char.GetNumericValue(userI2);
            int userI2i = (int)userI2d;

            fraction4.SetTop(userI1i);
            fraction4.SetBottom(userI2i);

            Console.WriteLine(fraction4.GetFractionString ());
            Console.WriteLine(fraction4.GetDecimalValue ());

            //Console.WriteLine($"{userI1}&{userI2}");
        }
        else
        {
            Console.WriteLine("error: the information you entered isn't correct.");
        }
    }
}