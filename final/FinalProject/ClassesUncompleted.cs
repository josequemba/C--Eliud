using System;

public class ClassesUncompleted : Portfolio
{
    public ClassesUncompleted (string name, string major, DateTime startingDate, DateTime endDate, string classes, int gradeInPercentage, int credits) 
    : base (name, major, startingDate, endDate, classes, gradeInPercentage, credits)
    {

    }

    public ClassesUncompleted (string classes, float gradeInPercentage, string status, string code, string description, int credits) 
    : base (classes, gradeInPercentage, status, code, description, credits)
    {

    }
    
    public override string GetStringDetails ()
    {
        return $"{GetCode ()} - {GetClassName ()} - {GetStatus ()} ---- {GetDescription ()} ----";
    }

    public override string GetStringRepresentation ()
    {
        return $"ClassesUncompleted:{GetCode ()},{GetClassName ()},{GetStatus ()},{GetDescription ()}";
    }
}
