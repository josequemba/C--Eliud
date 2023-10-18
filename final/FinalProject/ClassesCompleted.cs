using System;

public class ClassesCompleted : Portfolio
{
    public ClassesCompleted (string name, string major, DateTime startingDate, DateTime endDate, string classes, int gradeInPercentage, int credits) 
    : base (name, major, startingDate, endDate, classes, gradeInPercentage, credits)
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
