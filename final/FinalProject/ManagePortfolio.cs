using System;

public class ManagePortfolio
{
    List<Portfolio> _classes = new List<Portfolio> ();
    private int _status;

    public void DisplayCurrentClasses ()
    {

    }

    public int CalculateProgress ()
    {
        return 0;
    }

    public void DisplayMenu ()
    {
        List<string> menu = new List<string>
        {
            "",
            "Enter Graduation Requirements",
            "Enter classes",
            "Display Portfolio",
            "Report Grades",
            "Report Completed/ Dropped",
            "Save Portfolio",
            "Load Portfolio",
            "Quit"
        };

        Console.WriteLine("\nMenu Options:");
        for (int i = 1; i < menu.Count; i++)
        {
            Console.WriteLine($"  {i}. {menu[i]}");
        }
        Console.Write("Select an option from your menu: ");
    }

    public void Save ()
    {

    }

    public void Load ()
    {

    }

}