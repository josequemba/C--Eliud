using System;

public class ClassesCompleted : Portfolio
{
    public ClassesCompleted (string name, string major, DateTime startingDate, DateTime endDate, string classes, int gradeInPercentage, int credits) 
    : base (name, major, startingDate, endDate, classes, gradeInPercentage, credits)
    {

    }

    public ClassesCompleted (string classes, float gradeInPercentage, string status, string code, string description, int credits) 
    : base (classes, gradeInPercentage, status, code, description, credits)
    {

    }
    
    public override string GetStringDetails ()
    {
        return $"{GetClassNameIndex ()+1}. | {GetCode ()} - {GetClassName ()} - {GetStatus ()} - Grade: {CalculateGradeLetter(GetGrade ())}  ---- {GetDescription ()} ----  Credits: {GetCredits ()}";
    }

    public override string GetStringRepresentation ()
    {
        return $"ClassesCompleted:{GetCode ()},{GetClassName ()},{GetStatus ()},{GetGrade ()},{GetDescription ()},{GetCredits ()}";
    }
}
