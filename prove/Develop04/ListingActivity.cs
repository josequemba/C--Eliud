using System;

class ListingActivity : Activity
{
    private int _count;
    private List <string> _prompts = new List<string> ();
    private List<string> userInput = new List<string> ();

        public ListingActivity ()
        : base ()
    {
    }
    
    public ListingActivity (int count, string prompt)
    {
        _count = count;
        _prompts.Add(prompt);
    }

    public ListingActivity (string name, string description, int duration)
        : base (name, description, duration)
    {
    }
    
    public void Run ()
    {
        Console.WriteLine("Welcome to the Listing Activity.");

        Console.WriteLine("");

        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    
        Console.WriteLine("");
    }

    public void Run2 ()
    {
        DisplayStartingMessage ();

        ShowSpinner (4);

        Console.WriteLine ("List as many responses you can to the following prompt:");
        GetRandomPrompt ();
        Console.Write ("You may begin in: ");
        ShowCountDown (5);

        DateTime currenttime = DateTime.Now;
        DateTime futureTime = currenttime.AddSeconds(GetDuration());

        Console.WriteLine ("\n");

        string user;

        while (DateTime.Now < futureTime)
        {
            user = Console.ReadLine ();
        
            userInput.Add (user);

            _count = userInput.Count;
        }

        Console.WriteLine ($"You listed {_count} items!");

        Console.WriteLine("");

        DisplayEndingMessage ();
        ShowSpinner (2);
        Console.WriteLine("");

        Console.WriteLine($"You have completed another {GetDuration()} seconds of Listing Activity.");
        ShowSpinner (3);

    }
    public void GetRandomPrompt()
    {
        _prompts.Add (" --- Who are people that you appreciate? ---");
        _prompts.Add (" --- What are personal strengths of yours? ---");        
        _prompts.Add (" --- Who are people that you have helped this week? ---");  
        _prompts.Add (" --- When have you felt the Holy Ghost this month? ---"); 
        _prompts.Add (" --- Who are some of your personal heroes? ---");   

        Random random = new Random ();
        int promptIndex = random.Next (0, _prompts.Count);
        string prompt = _prompts [promptIndex];

        Console.WriteLine (prompt);
    }
}