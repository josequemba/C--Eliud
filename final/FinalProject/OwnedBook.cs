using System;

public class OwnedBook : Portfolio
{
    public OwnedBook (string booksAndTopics, string title, string author) 
    : base (booksAndTopics, title, author)
    {

    }

    
    public override string GetStringDetails ()
    {
        return $"Book: {GetBooksAndTopics ()} Author: {GetAuthor ()} Title: {GetTitle ()} ---- OWNED ----";
    }

    public override string GetStringRepresentation ()
    {
        return $"OwnedBook:{GetBooksAndTopics ()},{GetAuthor ()},{GetTitle ()}";
    }
}
