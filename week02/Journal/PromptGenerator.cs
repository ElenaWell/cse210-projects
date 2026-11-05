using System;
using System.Collections.Generic;

public class PromptGenerator
{
    // Attribute
    private List<string> _prompts;

    // Constructor
    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "What was the most meaningful moment of your day?",
            "What is one thing you learned today?",
            "Who made a positive impact on your day?",
            "What challenge did you overcome today?",
            "What are you grateful for today?",
            "What is something you wish you had done differently?",
            "When did you feel most motivated today?",
            "What is one thing you want to remember about today?"
        };
    }

    // Return a randomly selected prompt
    public string GetRandomPrompt()
    {
        int index = Random.Shared.Next(_prompts.Count);

        return _prompts[index];
    }
}
