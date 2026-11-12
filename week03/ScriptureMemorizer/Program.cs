

using System;

class Program
{
    static void Main(string[] args)
    {
        // Create the scripture reference
        Reference reference = new Reference("Proverbs", 3, 5);

        // Create the scripture
        Scripture scripture = new Scripture(
            reference,
            "Trust in the Lord with all your heart and lean not on your own understanding."
        );

        int roundsCompleted = 0;
        bool isRunning = true;

        Console.Clear();

        Console.WriteLine("SCRIPTURE MEMORIZER");
        Console.WriteLine("-------------------");

        while (isRunning)
        {
            Console.WriteLine();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();
            Console.WriteLine($"Hidden words: {scripture.GetHiddenWordCount()}");
            Console.WriteLine($"Remaining words: {scripture.GetVisibleWordCount()}");
            Console.WriteLine($"Rounds completed: {roundsCompleted}");

            // Calculate progress bar
            double progress = scripture.GetProgressPercentage();

            int barWidth = 20;
            int filled = (int)(progress / 100 * barWidth);
            int empty = barWidth - filled;

            Console.Write("Progress: ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(new string('█', filled));

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(new string('░', empty));

            Console.ResetColor();

            Console.WriteLine($" {progress:F1}%");

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine();
                Console.WriteLine("Congratulations! You memorized the scripture!");
                break;
            }

            Console.WriteLine();
            Console.Write("Press Enter to hide more words, or type 'quit' to exit: ");

            string input = Console.ReadLine();

            if (input != null && input.Trim().ToLower() == "quit")
            {
                isRunning = false;
                continue;
            }

            if (!string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid input. Press Enter or type 'quit'.");
                continue;
            }

            scripture.HideRandomWords(3);
            roundsCompleted++;

            Console.Clear();
        }

        Console.WriteLine();
        Console.WriteLine("Thank you for using Scripture Memorizer!");
    }
}
