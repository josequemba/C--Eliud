using System;
using System.Collections.Generic;
using System.ComponentModel;

public class LuchyPhases
{
    public List<string> _phrases = new List<string> ();

    public string _nameOfUser;

    public string RandomPhraser ()
    {
        _phrases.Add($"Stay strong, {_nameOfUser}. You've got this!");
        _phrases.Add($"Believe in yourself, {_nameOfUser}, because you are capable of amazing things.");
        _phrases.Add($"Chase your dreams, {_nameOfUser}, and don't stop until you reach them.");
        _phrases.Add($"Keep smiling, {_nameOfUser}, your positive energy is contagious.");
        _phrases.Add($"No obstacle is too big for {_nameOfUser} to overcome.");
        _phrases.Add($"Shine bright, {_nameOfUser}, the world needs your light.");
        _phrases.Add($"Every day is a new opportunity for {_nameOfUser} to succeed.");
        _phrases.Add($"Remember, {_nameOfUser}, you are loved and supported.");
        _phrases.Add($"Embrace each moment, {_nameOfUser}, and make it your own.");
        _phrases.Add($"Your journey, {_nameOfUser}, is unique and beautiful.");
        _phrases.Add($"{_nameOfUser}, you've got this! Keep moving forward with confidence.");
        _phrases.Add($"Believe in yourself, {_nameOfUser}, because you are stronger than you think.");
        _phrases.Add($"Stay resilient, {_nameOfUser}. Challenges are just opportunities in disguise.");
        _phrases.Add($"No dream is too big for {_nameOfUser} to achieve. Keep reaching for the stars.");
        _phrases.Add($"Keep smiling, {_nameOfUser}, and let your positivity light up the world.");
        _phrases.Add($"{_nameOfUser}, remember that setbacks are only setups for comebacks.");
        _phrases.Add($"You are capable of amazing things, {_nameOfUser}. Keep pushing your limits.");
        _phrases.Add($"Embrace each day with enthusiasm, {_nameOfUser}. Your journey is your own.");
        _phrases.Add($"Your determination, {_nameOfUser}, is an inspiration to others.");
        _phrases.Add($"Every step you take, {_nameOfUser}, brings you closer to your goals.");
        
        Random random = new Random ();
        int elementsIndex = random.Next (0, _phrases.Count);
        string promptPhrase = _phrases[elementsIndex];

        return promptPhrase;
    }
}