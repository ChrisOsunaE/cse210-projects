// Extra credit: Implemented a search feature to find entries by keyword.
using System;
using System.Collections.Generic;

class Program
{
    static Journal journal = new Journal();

    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\nPlease select an option:");
            Console.WriteLine("1. Create a new entry");
            Console.WriteLine("2. View all entries");
            Console.WriteLine("3. Load entries from file");
            Console.WriteLine("4. Save entries to file");
            Console.WriteLine("5. Search entries");
            Console.WriteLine("6. Exit");
            Console.Write("Your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Entry entry = new Entry();
                    entry.CreateEntry();
                    journal.AddEntry(entry);
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;
                case "4":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.WirtingToFile(saveFile);
                    break;
                case "5":
                    Console.Write("Enter keyword to search: ");
                    string keyword = Console.ReadLine();
                    journal.SearchEntries(keyword);
                    break;
                case "6":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
        Console.WriteLine("Goodbye!");
    }
}