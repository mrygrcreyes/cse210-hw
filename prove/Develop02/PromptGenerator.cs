using System;
public class Prompts
{
    public List<string> prompts = new List<string> 
    {
    "What are the things you're grateful for today?",
    "What steps did you take today towards a goal you're working on?",
    "What is something that made you laugh today?",
    "What was the best thing that happened to you today?",
    "What is one thing you want to remember from today?",
    "Who made your day better today?",
    "How can you make tomorrow better than today?"
    };

public string ChooseRandomPrompt()
{
    Random GetPrompt = new Random();
    int randomIndex = GetPrompt.Next(prompts.Count);
    string prompt = prompts[randomIndex];
    return prompt;
}

}