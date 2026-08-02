using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times when you have shown strength and resilience.")
    {
        LoadPromptsAndQuestions();
    }

    private void LoadPromptsAndQuestions()
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?"
        };
    }

    protected override void PerformActivityLogic()
    {
        Random random = new Random();
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"\n  *** {_prompts[random.Next(_prompts.Count)]} ***");
        Console.WriteLine("\nPress Enter when you have an experience in mind.");
        Console.ReadLine();

        Console.Clear();
        Console.WriteLine("Now ponder each of the following questions.");
        Console.Write("Starting in: ");
        ShowCountDown(5);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < futureTime)
        {
            string question = _questions[random.Next(_questions.Count)];
            Console.Write($"\n-> {question} ");
            ShowLoadingDots(6);
        }
    }
}