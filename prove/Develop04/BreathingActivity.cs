using System;
using System.Runtime.Intrinsics.Arm;

class BreathingActivity : Activity
{

    public BreathingActivity () : base ()
    {
    }
    public BreathingActivity (string name, string description, int duration) 
    : base (name, description, duration)
    {
    }


    public void Run ()
    {
        Console.WriteLine("Welcome to the Breathing Activity.");

        Console.WriteLine("");

        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
    
        Console.WriteLine("");
    }

    public void Run2 ()
    {
        DisplayStartingMessage ();

        ShowSpinner (4);
        
        DateTime currenttime = DateTime.Now;
        DateTime futureTime = currenttime.AddSeconds(GetDuration());

        while (DateTime.Now < futureTime)
        {
            Console.Write("\n\nBreathe in..."); 
            ShowCountDown (6);

            Console.Write("\nNow breathe out..."); 
            ShowCountDown (6);
        }

        Console.WriteLine("\n");

        DisplayEndingMessage ();
        ShowSpinner (2);
        Console.WriteLine("");

        Console.WriteLine($"You have completed another {GetDuration()} seconds of Breathing Activity.");
        ShowSpinner (3);
    }
}