using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    // Attribute
    private List<Entry> _entries;

    // Constructor
    public Journal()
    {
       _entries = new List<Entry>(); 
    }

    // Add an entry to the journal 
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // Display all journal entries
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("Your journal is empty.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // Save the journal to a text file
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                 writer.WriteLine(
                    $"{entry.Date}~|~{entry.PromptText}~|~{entry.EntryText}"
                );
            }
        }
        Console.WriteLine("Journal saved successfully!");
    }

    // Load the journal and replace existing entries
    public void LoadFromFile(string filename)
    {
       if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entries.Clear();

        using (StreamReader reader = new StreamReader(filename))
        {
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(
                    new string[] { "~|~" },
                    StringSplitOptions.None
                );

                if (parts.Length == 3)
                {
                    Entry entry = new Entry(
                        parts[0],
                        parts[1],
                        parts[2]
                    );

                    _entries.Add(entry);
                }
            }
        } 
        Console.WriteLine("Journal loaded successfully!");
        Console.WriteLine();
        DisplayAll();
    }

}