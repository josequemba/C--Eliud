using System;

public class MathAssignment : Assignment
{
    private string _textSection;
    private string _problems;
     
    public MathAssignment (string problems, string textSection, string studentName, string topic) : base(studentName, topic)
    {
        _problems = problems;
        _textSection = textSection;
    }
   
   public string GetHomeworkList()
   {
        return $"{_textSection} {_problems}.";
   }
}