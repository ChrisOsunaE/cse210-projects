using System;
using System.IO;

public class LogManager
{
    private string _fileName = "activity_log.txt";

    public void SaveLog(string activityName, int duration)
    {
        string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        string logEntry = $"{date} - {activityName}: {duration} seconds\n";
        
        File.AppendAllText(_fileName, logEntry);
    }

    public void DisplayLog()
    {
        Console.Clear();
        Console.WriteLine("=== YOUR MINDFULNESS JOURNEY ===");
        
        if (File.Exists(_fileName))
        {
            string[] lines = File.ReadAllLines(_fileName);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        else
        {
            Console.WriteLine("\nYou have not completed any activities yet. Start one today!");
        }

        Console.WriteLine("\nPress Enter to return to the main menu...");
        Console.ReadLine();
    }
}