using System;

class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    
    public Activity ()
    {
    }

    public Activity (string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage ()
    {
        Console.WriteLine("Get ready...");
    }

    public void DisplayEndingMessage ()
    {
        Console.WriteLine ("Well done!!");
        ShowSpinner (4);
    }

    public void ShowSpinner (int seconds)
    { 
        DateTime startTime = DateTime.Now;
        DateTime futuretime = startTime.AddSeconds(seconds);

        while (futuretime >= DateTime.Now)
        {
            List<string> symbols = new List<string> {
                "-",
                "\\",
                "|",
                "/"
            };

            foreach (string symbol in symbols)
            {
                Console.Write (symbol);

                Thread.Sleep (250);

                Console.Write ("\b \b");
            }
        }
    }

    public void ShowCountDown (int second)
    {
        for (int i = second; 0 < i; i--)
        {
            Console.Write (i);
            Thread.Sleep (1000);
            Console.Write("\b \b");
        }
    }

    public void menuOptions ()
    {
        List<string> options = new List<string> {
            "",
            "Start breathing activity",
            "Start refleting activity",
            "Start listing Activity",
            "Quit"
        };

        Console.WriteLine("Menu Options:");

        for (int i = 1; i < options.Count; i++)
        {
            Console.WriteLine($"  {i}. {options[i]}");
        }
    }

    public int GetDuration ()
    {
        return _duration;
    }
}