using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Front end Developer";
        job1._startYear = 2017;
        job1._endYear = 2019;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Software Developer";
        job2._startYear = 2020;
        job2._endYear = 2023;

        job1.DisplayJobDetails();
        job2.DisplayJobDetails();

        Resume myResume = new Resume ();
        myResume._personName = "Jose Quemba";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}