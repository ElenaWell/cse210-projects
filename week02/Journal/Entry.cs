using System;

public class Entry
{
    // Attributes
    private string _date;
    private string _promptText;
    private string _entryText;

    // Properties: allow other classes to read the entry information
    public string Date => _date;
    public string PromptText => _promptText;
    public string EntryText => _entryText;

    // Constructor
    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    // Behavior
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Response: {_entryText}");
        Console.WriteLine($"Word Count: {GetWordCount()}");
        Console.WriteLine();
    }

    // Creativity Enhancement: Count words in the journal response
    public int GetWordCount()
    {
        string[] words = _entryText.Split(
            ' ',
            StringSplitOptions.RemoveEmptyEntries
        );

        return words.Length;
    }
}
