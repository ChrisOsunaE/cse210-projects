using System;
using System.IO;

public class JournalManger
{
    public void DisplayAllJournals()
    {
        Console.WriteLine("Displaying all journals...");
        string[] journalFiles = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.txt");
        if (journalFiles.Length == 0)
        {
            Console.WriteLine("No journals found.");
            return;
        }else
        {
          foreach (var file in journalFiles)
          if (Path.GetFileNameWithoutExtension(file) != "prompts")
            {
                Console.WriteLine(Path.GetFileNameWithoutExtension(file));
            }
        }
    }
}