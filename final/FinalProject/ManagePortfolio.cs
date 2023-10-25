using System;
using System.ComponentModel.DataAnnotations;

public class ManagePortfolio
{
    List<Portfolio> _classes = new List<Portfolio> ();
    private float _gpa;
    private int _statusCredit;
    private int _gpaRequirement = 2;
    private int _hoursRequirement = 120;
    private int _credtsRequrements = 30;

    CurrentClasses currentClasses1 = new CurrentClasses ();

    public void DisplayCurrentClasses ()
    {
        currentClasses1.DisplayPersonal ();
        DisplayReAndSt ();
        Console.WriteLine("");
        foreach (Portfolio clas in _classes)
        {
            Console.WriteLine(clas.GetStringDetails());
        }
        Console.WriteLine("");
    }

    public void DisplayMenu ()
    {
        List<string> menu = new List<string>
        {
            "",
            "Enter Graduation Requirements",
            "Enter classes",
            "Display Portfolio",
            "Report Grades",
            "Enter a Book you own",
            "Enter a Book you Want",
            "Enter a Topic to Study later",
            "Save Portfolio",
            "Load Portfolio",
            "Quit"
        };

        Console.WriteLine("\nMenu Options:");
        for (int i = 1; i < menu.Count; i++)
        {
            Console.WriteLine($"  {i}. {menu[i]}");
        }
        Console.Write("Select an option from your menu: ");
    }

    public void RequirementsSetter ()
    {
        Console.Write("Enter the minimum required GPA: ");
        _gpaRequirement = int.Parse(Console.ReadLine ());

        Console.Write("Enter the minimum required Hours: ");
        _hoursRequirement = int.Parse(Console.ReadLine ());

        Console.Write("Enter the minimum required Credits: ");
        _credtsRequrements = int.Parse(Console.ReadLine ());
    }

    public void ClassesSetterMenu ()
    {
        List<string> menu2 = new List<string>
        {
            "",
            "Completed Class",
            "Current Class",
            "Future Class",
        };

        for (int i = 1; i < menu2.Count; i++)
        {
            Console.WriteLine($"  {i}. {menu2[i]}");
        }
        Console.Write("  Select an option from the class menu: ");
    }
    
    public void ClassesSetter (int response)
    {
        currentClasses1.personalDataSetter ();

        Console.WriteLine("Please enter the following.");

        if (response == 1)
        {    
            Console.Write("Class Name: ");
            string className = Console.ReadLine ();

            Console.Write("Class Code/Number: ");
            string code = Console.ReadLine ();

            string status = "Completed Class";

            Console.Write("Class grade in percentage: ");
            float grade = int.Parse(Console.ReadLine ());

            Console.Write("Class description: ");
            string description = Console.ReadLine ();

            Console.Write("Class credits: ");
            int credits = int.Parse(Console.ReadLine ());
            
            ClassesCompleted classescompleted = new ClassesCompleted (className, grade, status, code, description, credits);

            _classes.Add (classescompleted);
            _gpa += classescompleted.CalculateGpa ();
            _statusCredit += classescompleted.GetSumCredits ();
        }
        
        else if (response == 2)
        {
            Console.Write("Class Name: ");
            string className = Console.ReadLine ();

            Console.Write("Class Code/Number: ");
            string code = Console.ReadLine ();

            string status = "Current Class";

            Console.Write("Class current grade in percentage: ");
            float grade = int.Parse(Console.ReadLine ());

            Console.Write("Class description: ");
            string description = Console.ReadLine ();

            Console.Write("Class credits: ");
            int credits = int.Parse(Console.ReadLine ());

            CurrentClasses currentClasses = new CurrentClasses (className, grade, status, code, description, credits);

            _classes.Add (currentClasses);
            _gpa += currentClasses.CalculateGpa ();
            _statusCredit += currentClasses.GetSumCredits ();
        }
        
        else if (response == 3)
        {
            Console.Write("Class Name: ");
            string className = Console.ReadLine ();

            Console.Write("Class Code/Number: ");
            string code = Console.ReadLine ();

            string status = "Future Class";

            Console.Write("Class description: ");
            string description = Console.ReadLine ();

            ClassesUncompleted classesUncompleted = new ClassesUncompleted (className, 0, status, code, description, 0);

            _classes.Add (classesUncompleted);
            _statusCredit += classesUncompleted.GetSumCredits ();
            _gpa += classesUncompleted.CalculateGpa ();
        }
    }

    public int CalculateProgress ()
    {
        return 0;
    }

    public void Save ()
    {
        Console.Write ("What is the name of the file you want to save? ");
        string fileName = Console.ReadLine();
        using(StreamWriter outputFile = new StreamWriter (fileName))
        {
            foreach (Portfolio clas in _classes)
            {
                outputFile.WriteLine ($"{clas.GetStringRepresentation()}");
            }
        }
    }

    public void Load ()
    {
        List<string> linesTo = new List<string> ();
        
        Console.Write ("What is the filename name that you want to load? ");
        string fileName1 = Console.ReadLine();
        
        using (StreamReader reader = new StreamReader (fileName1))
        {
            int lineIndex = 0;
            int targetLineIndex = 0;

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                if (lineIndex == targetLineIndex)
                {
                    linesTo.Add($"{line}");
                }
                lineIndex ++;
                targetLineIndex ++; 
            }
        }
        foreach (string item in linesTo)
        {   
            string[] mother = item.Split(":");

            if (mother.Count() == 2)
            {
                string className = mother[0];
                
                string part2 = mother[1];

                if (className == "CurrentClasses")
                {
                    string[] elements = part2.Split (",");
                    string codeLoad = elements[0];
                    string classeNameLoad = elements[1];
                    string statusLoad = elements[2];
                    int gradeLoad = int.Parse(elements[3]);
                    string descriptionLoad = elements[4];
                    int creditsLoad = int.Parse(elements[5]);

                    CurrentClasses currentClasses = new CurrentClasses (classeNameLoad, gradeLoad, statusLoad, codeLoad, descriptionLoad, creditsLoad);
                    _classes.Add (currentClasses);
                    _gpa += currentClasses.CalculateGpa ();
                    _statusCredit += currentClasses.GetSumCredits ();
                }
                else if (className == "ClassesCompleted")
                {
                    string[] elements = part2.Split (",");
                    string codeLoad = elements[0];
                    string classeNameLoad = elements[1];
                    string statusLoad = elements[2];
                    int gradeLoad = int.Parse(elements[3]);
                    string descriptionLoad = elements[4];
                    int creditsLoad = int.Parse(elements[5]);

                    ClassesCompleted classesCompleted = new ClassesCompleted (classeNameLoad, gradeLoad, statusLoad, codeLoad, descriptionLoad, creditsLoad);
                    _classes.Add (classesCompleted);
                    _gpa += classesCompleted.CalculateGpa ();
                    _statusCredit += classesCompleted.GetSumCredits ();
                }
                else if (className == "ClassesUncompleted")
                {
                    string[] elements = part2.Split (",");
                    string codeLoad = elements[0];
                    string classeNameLoad = elements[1];
                    string statusLoad = elements[2];
                    string descriptionLoad = elements[3];

                    ClassesUncompleted classesUncompleted = new ClassesUncompleted (classeNameLoad, 0, statusLoad, codeLoad, descriptionLoad, 0);
                    _classes.Add (classesUncompleted);
                    _gpa += classesUncompleted.CalculateGpa ();
                    _statusCredit += classesUncompleted.GetSumCredits ();
                }
                else if (className == "OwnedBook")
                {
                    string[] elements = part2.Split (",");
                    string bookLoad = elements[0];
                    string authorLoad = elements[1];
                    string titleLoad = elements[2];
                    
                    OwnedBook ownedBook = new OwnedBook (bookLoad, titleLoad, authorLoad);
                    _classes.Add (ownedBook);
                }

                else if (className == "WantedBooks")
                {
                    string[] elements = part2.Split (",");
                    string bookLoad = elements[0];
                    string authorLoad = elements[1];
                    string titleLoad = elements[2];
                    
                    WantedBooks wantedBooks = new WantedBooks (bookLoad, titleLoad, authorLoad);
                    _classes.Add (wantedBooks);
                }

                else if (className == "StudyTopics")
                {
                    string[] elements = part2.Split (",");
                    string topic = elements[0];
                    string source = elements[1];
                    
                    StudyTopics studyTopics = new StudyTopics (topic, source);
                    _classes.Add (studyTopics);
                }
            }
        }
    }

    public float GetGpa ()
    {
        return _gpa;
    }

    public void DisplayReAndSt ()
    {
        Console.WriteLine($"REQUIREMENT: GPA:{_gpaRequirement} --- HOURS: {_hoursRequirement} - CREDITS: {_credtsRequrements}");
        Console.WriteLine($"STUDENT:     GPA:{_gpa} --- HOURS: {_statusCredit*3} - CREDITS: {_statusCredit}");
    
        string progressingBar = "||||||||||||||||||||||||||||||||||||||||||||||||||";

        float top = (float)_statusCredit;
        float bottom = (float)_credtsRequrements;

        int lengthb = progressingBar.Length;

        float percentage = lengthb * (top/bottom);

        string bar = progressingBar.Substring(0, (int)percentage);

        Console.WriteLine($"{bar} ► {percentage*2}%");
    }   

    public void ReportGrade ()
    {        
        foreach (Portfolio clas in _classes)
        {    
            Console.WriteLine(clas.GetStringDetails ());

            Console.Write ("What class would you like to record (enter index): ");
            int userRecordIndex = int.Parse(Console.ReadLine());

            Console.Write("What is the new grade in percentage: ");
            float newGrade = float.Parse(Console.ReadLine());

            clas.RecordGrade (userRecordIndex-1, newGrade);
        }
    }

    public void BookSetter ()
    {
        Console.WriteLine("Please enter the following.");

        Console.Write("Topic of the Book: ");
        string book = Console.ReadLine ();

        Console.Write("The author of the Book: ");
        string author = Console.ReadLine ();

        Console.Write("The title of the Book: ");
        string title = Console.ReadLine ();

        OwnedBook ownedBook  = new OwnedBook (book, title, author);

        _classes.Add (ownedBook);
    }

    public void WantBookSetter ()
    {
        Console.WriteLine("Please enter the following.");

        Console.Write("Topic of the Book: ");
        string book = Console.ReadLine ();

        Console.Write("The author of the Book: ");
        string author = Console.ReadLine ();

        Console.Write("The title of the Book: ");
        string title = Console.ReadLine ();

        WantedBooks wantedBooks = new WantedBooks (book, title, author);

        _classes.Add (wantedBooks);
    }
   
    public void TopicSetter ()
    {
        Console.WriteLine("Please enter the following.");

        Console.Write("Topic of study: ");
        string topic = Console.ReadLine ();

        Console.Write("The best source: ");
        string source = Console.ReadLine ();

        StudyTopics studyTopics = new StudyTopics (topic, source);

        _classes.Add (studyTopics);
    }
}