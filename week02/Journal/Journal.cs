using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public string _journalName;

    public Journal(string Name)
    {
        _journalName = Name;
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
        Console.WriteLine("Entry added successfully.");
    }

    public void DisplayAllEntries()
    {
      Console.WriteLine($"Journal: {_journalName}");
        foreach (var entry in _entries)
        {
            entry.DisplayEntry();
        }
        Console.WriteLine("All entries displayed successfully.");
    }

    public void DisplayAllJournals()
    {
        Console.WriteLine("Displaying all journals...");
        string[] journalFiles = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.txt");
        foreach (var file in journalFiles)
        {
            Console.WriteLine(Path.GetFileNameWithoutExtension(file));
        }
    }

    public void SaveToFile()
    {
      string filename = $"{_journalName}.txt";
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry._dateTime}|{entry._promptText}|{entry._entryText}");
            }
        }
        Console.WriteLine($"Entries saved to {filename} successfully.");
    }

    public void LoadFromFile()
    {
        string filename = $"{_journalName}.txt";
        if (File.Exists(filename))
        {
          _entries.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Entry entry = new Entry();
                    entry.parseEntry(line); 
                    _entries.Add(entry);
                    entry.DisplayEntry();
                }
            }
            Console.WriteLine($"Entries loaded from {filename} successfully.");
        }
        else
        {
            Console.WriteLine($"File {filename} does not exist.");
        }
    }
  }