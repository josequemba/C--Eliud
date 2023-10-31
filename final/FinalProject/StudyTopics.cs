using System;

public class StudyTopics : Portfolio
{
    private List <string> _source = new List<string> ();

    public StudyTopics (string booksAndTopics, string source) 
    : base (booksAndTopics)
    {
        _source.Add (source);
    }

    public string GetSource()
    {
        foreach (string sour in _source)
        {
            return sour;
        }
        return "";
    }
    
    public override string GetStringDetails ()
    {
        return $"Topic to Study: {GetBooksAndTopics ()} Source: {GetSource()}";
    }

    public override string GetStringRepresentation ()
    {
        return $"StudyTopics:{GetBooksAndTopics ()},{GetSource()}";
    }
}
