using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning04 World!");

        Assignment assign1 = new Assignment ("Jose Quemba", "Cut leaves");
        Console.WriteLine(assign1.GetSummary());

        Console.WriteLine("");

        MathAssignment mathAssignment = new MathAssignment ("Problems 8-19", "Section 7.3", "João Carlos", "Casa Azul");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        Console.WriteLine("");

        WritingAssignment writingAssignment = new WritingAssignment ("The Causes of World War II", "Mary Waters", "European History");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}