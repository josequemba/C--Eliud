using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    

    //to add string for the file
    public List<string> _toString = new List<string>();

    public void AddEntry (Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll ()
    {
        foreach (Entry words in _entries)
        {
            words.Display ();
        }
    }

    public void SaveToFile (string file)
    {
        string fileName = file;
        using(StreamWriter outputFile = new StreamWriter (fileName))
        {
            foreach (string words1 in _toString)
            {
                outputFile.WriteLine ($"{words1}");
            }
        }
    }

    public void LoadFromFile (string file)
    {
        string fileName1 = file;
        string [] lines = System.IO.File.ReadAllLines (fileName1);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}

