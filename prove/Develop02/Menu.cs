using System;
using System.Collections.Generic;

public class Menu
{ 
    List<string> _menuN = new List<string>
        {
            "",
            "Write",
            "Display",
            "Load",
            "Save",
            "Luchy phrase",
            "Quit"
        };

    public void DisplayMenu ()
    {
        Console.WriteLine("Please Select one of the following choices:");

        for (int i=1; i < _menuN.Count; i+=1)
        {
            Console.WriteLine($"{i}. {_menuN[i]}");
        }
    }
}