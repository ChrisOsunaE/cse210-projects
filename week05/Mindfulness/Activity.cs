using System;
using System.Threading;

public abstract class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void RunActivity()
    {
        DisplayStartingMessage();
        PerformActivityLogic(); 
        DisplayEndingMessage();
        
        LogActivity(); 
    }

    protected abstract void PerformActivityLogic();

    private void LogActivity()
    {
        LogManager logger = new LogManager();
        logger.SaveLog(_name, _duration);
    }

    private void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"=== {_name} ===");
        Console.WriteLine($"\n{_description}\n");
        Console.Write("How many seconds would you like to dedicate to this session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Prepare to begin...");
        ShowLoadingDots(4);
    }

    private void DisplayEndingMessage()
    {
        Console.WriteLine("\nExcellent work!");
        ShowLoadingDots(3);
        Console.WriteLine($"\nYou have successfully completed {_duration} seconds of the {_name}.");
        ShowLoadingDots(4);
    }

    protected void ShowLoadingDots(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"[{i}]");
            Thread.Sleep(1000);
            Console.Write("\b\b\b   \b\b\b");
        }
    }
}