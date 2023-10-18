using System;

public class StudyTopics : Portfolio
{
    List <string> _source = new List<string> ();

    public StudyTopics (string booksAndTopics, string source) 
    : base (booksAndTopics)
    {
        _source.Add (source);
    }

    
    public override string GetStringDetails ()
    {
        return "";
    }

    public override string GetStringRepresentation ()
    {
        return "";
    }
}
