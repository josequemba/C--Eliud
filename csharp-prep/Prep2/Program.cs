using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine ();
        int gradePercentage = int.Parse(userInput);


        string studentGrade = "";        

        if (gradePercentage >= 90)
        {
            studentGrade = "A";
        }
        else if (gradePercentage >= 80)
        {
            studentGrade = "B";
        }
        else if (gradePercentage >= 70)
        {
            studentGrade = "C";
        }
        else if (gradePercentage >= 60)
        {
            studentGrade = "D";
        }
        else
        {
            studentGrade = "F";
        }

        Console.WriteLine($"Your grrade Letter is {studentGrade}");

        if (gradePercentage >= 70)
        {
            Console.WriteLine($"Congratulations you passed! Keep up the good work.");
        }
        else
        {
         Console.WriteLine("Try again and do your best.");   
        }
    }
}