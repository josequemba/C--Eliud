using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop04 World!");

        Activity activity = new Activity ();

        int times = 0;

        int stopAndQuit = 0;

        while (stopAndQuit != 4)
        {
            DateTime startTime = DateTime.Now;

            activity.menuOptions ();

            if (times == 0)
            {
            }
            else if (times == 1)
            {
                Console.WriteLine($"You have performed {times} activity already");
            }
            else
            {
                Console.WriteLine($"You have performed {times} activities already");
            }

            times ++;

            Console.Write ("Select a choice from the Menu: ");
            stopAndQuit = int.Parse(Console.ReadLine ());

            Console.Clear ();

            if (stopAndQuit == 1)
            {
                BreathingActivity Bactivity = new BreathingActivity ();
                Bactivity.Run();

                Console.Write ("How long, in seconds, would you like for your session? ");
                int userInput1 = int.Parse(Console.ReadLine ());

                Console.Clear ();

                BreathingActivity Bactivity1 = new BreathingActivity ("Jose", "Good", userInput1);
                Bactivity1.Run2();

                Console.Clear ();
            };

            if (stopAndQuit == 2)
            {
                ReflectingActivity Ractivity = new ReflectingActivity ();
                Ractivity.Run();

                Console.Write ("How long, in seconds, would you like for your session? ");
                int userInput2 = int.Parse(Console.ReadLine ());

                Console.Clear ();

                ReflectingActivity Ractivity1 = new ReflectingActivity ("Jose", "Good", userInput2);
                Ractivity1.Run2();

                Console.Clear ();
            };

            if (stopAndQuit == 3)
            {
                ListingActivity Lactivity = new ListingActivity ();
                Lactivity.Run();

                Console.Write ("How long, in seconds, would you like for your session? ");
                int userInput3 = int.Parse(Console.ReadLine ());

                Console.Clear ();

                ListingActivity Lactivity1 = new ListingActivity ("Jose", "Good", userInput3);
                Lactivity1.Run2();

                Console.Clear ();
            };

            DateTime endTime = DateTime.Now;

            TimeSpan totalTime = endTime - startTime;

            Console.WriteLine("The total time spent: " + (int)totalTime.TotalSeconds + " seconds");
        }
        
    }
}