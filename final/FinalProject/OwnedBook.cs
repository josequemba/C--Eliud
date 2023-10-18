using System;

public class OwnedBook : Portfolio
{
    public OwnedBook (string booksAndTopics, string title, string author) 
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
