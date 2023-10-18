using System;

public abstract class Portfolio 
{
    private string _name;
    private string _major;
    private DateTime _startingDate;
    private DateTime _endDate;
    List <string> _title = new List<string> ();
    List <string> _author = new List<string> ();
    List <string> _classes = new List <string> ();
    List <string> _booksAndTopics = new List <string> ();
    List <int> _gpa = new List <int> ();
    List <int> _gradeInPercentage = new List <int> ();
    List <int> _credits = new List <int> ();

    public Portfolio (string name, string major, DateTime startingDate, DateTime endDate, string classes, int gradeInPercentage, int credits)
    {
        _name = name;
        _major = major;
        _startingDate = startingDate;
        _endDate = endDate;
        _classes.Add (classes);
        _gradeInPercentage.Add (gradeInPercentage);
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

    public abstract string GetStringDetails ();

    public abstract string GetStringRepresentation ();

    public void CalculateGpa ()
    {

    }

    public string CalculateGradeLetter ()
    {
        return "";
    }    

}