using System;
using System.IO; 

class Journal
{
    public List<Entry> entries = new List<Entry>();

    public void addingNewEntry( Entry entry)
    {
        entries.Add(entry);
    }

    public void displayAllEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry.getEntry());
        }
    }

    public void savingFile( String fileName )
    {
        Console.WriteLine("saving to file...");
        using(StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (var entry in entries)
            {
                outputFile.WriteLine(entry.getEntryCSV());
            }
        }

    }

    public void LoadFile( String fileName )
    {
        String[] lines = File.ReadAllLines(fileName);
        foreach (var line in lines)
        {
            string[] parts = line.Split("|");

            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];

            Entry newEntry = new Entry(date, prompt, response);
            
            entries.Add(newEntry);
        }

    }

    
}