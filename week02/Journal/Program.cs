/*
     * Creativity Enhancement:
     * Each journal entry displays its word count.
     * This helps users track how much they write in their journal.
     * The word count is calculated by the Entry class.
     */
using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool running = true;

        while (running)
        {
            DisplayMenu();

            string choice = GetUserChoice();

            switch (choice)
            {
                case "1":
                    WriteEntry(journal, promptGenerator);
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    LoadJournal(journal);
                    break;

                case "4":
                    SaveJournal(journal);
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Thank you for using the Journal Program!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    // Display the main menu
    static void DisplayMenu()
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine();
        Console.WriteLine("Please select one of the following choices:");

        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display journal");
        Console.WriteLine("3. Load journal");
        Console.WriteLine("4. Save journal");
        Console.WriteLine("5. Quit");

        Console.Write("What would you like to do? ");
    }

    // Get the user's menu selection
    static string GetUserChoice()
    {
        return Console.ReadLine() ?? "";
    }

    // Create and add a new journal entry
    static void WriteEntry(Journal journal, PromptGenerator promptGenerator)
    {
        string prompt = promptGenerator.GetRandomPrompt();

        Console.WriteLine();
        Console.WriteLine(prompt);
        Console.Write("> ");

        string response = Console.ReadLine() ?? "";

        string date = DateTime.Now.ToString("MMMM dd, yyyy");

        Entry newEntry = new Entry(date, prompt, response);

        journal.AddEntry(newEntry);

        Console.WriteLine("Entry added successfully!");
    }

    // Save the journal to a file
    static void SaveJournal(Journal journal)
    {
        Console.Write("Enter filename: ");

        string filename = Console.ReadLine() ?? "";

        if (string.IsNullOrWhiteSpace(filename))
        {
            Console.WriteLine("Filename cannot be empty.");
            return;
        }

        journal.SaveToFile(filename);
    }

    // Load the journal from a file
    static void LoadJournal(Journal journal)
    {
        Console.Write("Enter filename: ");

        string filename = Console.ReadLine() ?? "";

        if (string.IsNullOrWhiteSpace(filename))
        {
            Console.WriteLine("Filename cannot be empty.");
            return;
        }

        journal.LoadFromFile(filename);
    }

    
}
