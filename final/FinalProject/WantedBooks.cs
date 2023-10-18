using System;

public class WantedBooks : Portfolio
{
    public WantedBooks (string booksAndTopics, string title, string author) 
    : base (booksAndTopics, title, author)
    {

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
