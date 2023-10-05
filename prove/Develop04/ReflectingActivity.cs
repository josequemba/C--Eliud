using System;

class ReflectingActivity : Activity
{
    private List <string> _prompts = new List<string> ();
    private List <string> _questions = new List<string> ();

    public ReflectingActivity ()
        : base ()
    {
    }

    public ReflectingActivity (string name, string description, int duration)
        : base (name, description, duration)
    {
    }

    public ReflectingActivity (List<string> prompts, List<string> questions, string name, string description, int duration)
        : base (name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public void Run ()
    {
        Console.WriteLine("Welcome to the Reflecting Activity.");

        Console.WriteLine("");

        Console.WriteLine("This activity will help you reflect on times in your life" + 
        " when you have shown strength and resilience. This will help you recognize the" + 
        " power you have and how you can use it in other aspects of your life.");
    
        Console.WriteLine("");
    }

    public void Run2 ()
    {
        DisplayStartingMessage ();

        ShowSpinner (4);
        
        Console.WriteLine ("Consider the following prompt:\n");
        Console.WriteLine (GetRandomPrompt ());

        Console.WriteLine ("");

        Console.WriteLine ("When you have something in mind, press enter to continue. ");
        Console.ReadLine ();

        Console.WriteLine ("Now ponder on each of the followning questions as they related to this experience.");
        Console.Write ("You may begin in: ");

        ShowCountDown (5);

        Console.Clear ();

        DateTime currenttime = DateTime.Now;
        DateTime futureTime = currenttime.AddSeconds(GetDuration());

        while (DateTime.Now < futureTime)
        {
            Console.WriteLine("");
            Console.Write(GetRandomQuestion (),""); 
            ShowSpinner (13);
        }

        Console.WriteLine("\n");

        DisplayEndingMessage ();
        ShowSpinner (2);
        Console.WriteLine("");

        Console.WriteLine($"You have completed another {GetDuration()} seconds of Reflecting Activity.");
        ShowSpinner (3);
    }

    public string GetRandomPrompt ()
    {
        _prompts.Add ("--- Think of a time when you stood up for someone else. ---");
        _prompts.Add ("--- Think of a time when you did something really difficult. ---");
        _prompts.Add ("--- Think of a time when you helped someone in need. ---");
        _prompts.Add ("--- Think of a time when you did something truly selfless. ---");
    
        Random random = new Random ();
        int promptIndex = random.Next (0, _prompts.Count);
        string prompt = _prompts [promptIndex];

        return prompt;
    }

    public string GetRandomQuestion () 
    {
        _questions.Add ("Why was this experience meaningful to you? ");
        _questions.Add ("Have you ever done anything like this before? ");        
        _questions.Add ("How did you get started?");        
        _questions.Add ("How did you feel when it was complete?");        
        _questions.Add ("What made this time different than other times when you were not as successful?");        
        _questions.Add ("What is your favorite thing about this experience?");        
        _questions.Add ("What could you learn from this experience that applies to other situations?");        
        _questions.Add ("What did you learn about yourself through this experience?");        
        _questions.Add ("How can you keep this experience in mind in the future?");

        Random random = new Random ();
        int questionIndex = random.Next (0, _questions.Count);
        string question = _questions [questionIndex];

        return question;
    }

    public void DisplayPrompt ()
    {
        foreach (string prompts in _prompts)
        {
            Console.WriteLine (prompts);
        }
    }

    public void DisplayQuestions ()
    {
        foreach (string questions in _questions)
        {
            Console.WriteLine (questions);
        }
    }
}