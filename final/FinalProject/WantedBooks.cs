using System;

public class WantedBooks : Portfolio
{
    public WantedBooks (string booksAndTopics, string title, string author) 
    : base (booksAndTopics, title, author)
    {

    }

    
    public override string GetStringDetails ()
    {
        return $"Book: {GetBooksAndTopics ()} Author: {GetAuthor ()} Title: {GetTitle ()} ---- NEED TO BUY ----";;
    }

    public override string GetStringRepresentation ()
    {
        return $"WantedBooks:{GetBooksAndTopics ()},{GetAuthor ()},{GetTitle ()}";
    }
}
