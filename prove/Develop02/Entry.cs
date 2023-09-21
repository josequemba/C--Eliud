using System;
using System.Collections.Generic;
using System.Security.AccessControl;
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _luchyPrase;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText} \n{_entryText} \nLucky Phrase: {_luchyPrase}\n");
    }
}
