using System;

public abstract class Portfolio 
{
    private string _name;
    private string _major;
    private DateTime _startingDate;
    private DateTime _endDate;
    private List <string> _status = new List<string> ();   
    private List <string> _code = new List<string> ();
    private List <string> _description = new List<string> ();
    private List <string> _title = new List<string> ();                
    private List <string> _author = new List<string> ();                    
    private List <string> _classes = new List <string> ();
    private List <string> _booksAndTopics = new List <string> ();               
    private List <float> _gradeInPercentage = new List <float> ();
    private List <int> _credits = new List <int> ();


    public Portfolio ()
    {
        _name = "N/A";
        _major = "N/A";
    }
    public Portfolio (string name, string major, DateTime startingDate, DateTime endDate, string classes, int gradeInPercentage, int credits)
    {
        _name = name;
        _major = major;
        _startingDate = startingDate;
        _endDate = endDate;
        _classes.Add (classes);
        _gradeInPercentage.Add (gradeInPercentage);
        _credits.Add(credits);
    }
    public Portfolio (string classes, float gradeInPercentage,  string status, string code, string description, int credits)
    {
        _classes.Add (classes);
        _gradeInPercentage.Add (gradeInPercentage);
        _status.Add (status);
        _code.Add (code);
        _description.Add (description);
        _credits.Add (credits);
    }

    public Portfolio (string booksAndTopics, string title, string author)
    {
        _booksAndTopics.Add (booksAndTopics);
        _title.Add (title);
        _author.Add(author);
    }

    public Portfolio (string booksAndTopics)
    {
        _booksAndTopics.Add (booksAndTopics);
    }

    public void personalDataSetter ()
    { 
        if (_name == "N/A")
        {
            Console.WriteLine ("Please enter the follow before anything. ");

            Console.Write ("Enter your name: ");
            _name = Console.ReadLine();
          
            Console.Write ("Enter your major: ");
            _major = Console.ReadLine();
            
            Console.Write ("The starting date of school (yyyy-MM-dd): ");
            DateTime dateTime1 = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", null);
            _startingDate = dateTime1;

            Console.Write ("The end date (yyyy-MM-dd): ");
            DateTime dateTime2 = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", null);
            _endDate = dateTime2;
        }
    }
    public abstract string GetStringDetails ();

    public abstract string GetStringRepresentation ();

    public int CalculateGpa ()
    {
        double totalGpa = 0;

        for (int i = 0; i < _gradeInPercentage.Count; i++)
        {
            
            string grade = CalculateGradeLetter((int)_gradeInPercentage[i]); 

            if (grade == "A")
            {
                totalGpa += 4.0 * grade.Count(); 
            }
            else if (grade == "B")
            {
                totalGpa += 3.4 * grade.Count(); 
            }
            else if (grade == "C")
            {
                totalGpa += 2.4 * grade.Count(); 
            }
            else if (grade == "D")
            {
                totalGpa += 1.4 * grade.Count(); 
            }
            else if (grade == "F")
            {
                totalGpa += 0.0 * grade.Count(); 
            }
            
            return (int)totalGpa / _gradeInPercentage.Count ();
        }
        return 0;
    }
    
    public string CalculateGradeLetter (int number)
    {
        string studentGrade;

        if (number >= 90)
        {
            studentGrade = "A";
        }
        else if (number >= 80)
        {
            studentGrade = "B";
        }
        else if (number >= 70)
        {
            studentGrade = "C";
        }
        else if (number >= 60)
        {
            studentGrade = "D";
        }
        else
        {
            studentGrade = "F";
        }

        return studentGrade;
    }    

    public string DisplayPersonal ()
    {
        return $"Name: {_name} \nMajor: {_major} \nStarted School: {_startingDate} \nGraduate: {_endDate}";
    }

    public string GetCode ()
    {
        foreach (string cod in _code)
        {
            return cod;
        }
        return "";
    }
    public string GetClassName ()
    {
        foreach (string clas in _classes)
        {
            return clas;
        }
        return "";
    }

    public int GetClassNameIndex ()
    {
        for(int i = 0; i < _classes.Count; i++)
        {
            return i;
        }
        return 1;
    }

    public int GetGrade ()
    {
        foreach (int grad in _gradeInPercentage)
        {
            return grad;
        }
        return 0;
    }
    public string GetDescription ()
    {
        foreach (string descrip in _description)
        {
            return descrip;
        }
        return "";
    }
    public string GetStatus ()
    {
        foreach (string stat in _status)
        {
            return stat;
        }
        return "";
    }

    public int GetCredits ()
    {
        foreach (int cred in _credits)
        {
            return cred;
        }
        return 0;
    }

    public int GetSumCredits ()
    {
        return _credits.Sum();
    }

    public void RecordGrade (int number, float newNumber)
    {
        if (number >= 0 && number < _gradeInPercentage.Count)
        {
            _gradeInPercentage[number] = newNumber;
        }
    }

    public string GetTitle ()
    {
        foreach (string til in _title)
        {
            return til;
        }
        return "";
    }

    public string GetAuthor()
    {
        foreach (string aut in _author)
        {
            return aut;
        }
        return "";
    }

    public string GetBooksAndTopics()
    {
        foreach (string bat in _booksAndTopics)
        {
            return bat;
        }
        return "";
    }
}