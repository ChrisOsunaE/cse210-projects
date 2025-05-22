using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
  public List<Entry> _entries = new List<Entry>();

  public void AddEntry(Entry entry)
  {
    _entries.Add(entry);
  }

  public void DisplayEntries()
  {
    if (_entries.Count == 0)
    {
      Console.WriteLine("No entries found.");
      return;
    }

    foreach (Entry entry in _entries)
    {
      entry.DisplayEntry();
    }
  }

  public void WirtingToFile(string filename)
  {
    using (StreamWriter outputFile = new StreamWriter(filename))
    {
      foreach (Entry entry in _entries)
      {
        outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._content}");
      }
    }
    Console.WriteLine($"Journal saved to {filename}");
  }

  public void LoadFromFile(string filename)
  {
    if (!File.Exists(filename))
    {
      Console.WriteLine("File not found.");
      return;
    }

    _entries.Clear();
    string[] lines = File.ReadAllLines(filename);

    foreach (string line in lines)
    {
      string[] parts = line.Split('|');
      if (parts.Length == 3)
      {
        Entry entry = new Entry
        {
          _date = parts[0],
          _prompt = parts[1],
          _content = parts[2]
        };
        _entries.Add(entry);
      }
    }
  }
  public void SearchEntries(string keyword)
  {
    List<Entry> foundEntries = new List<Entry>();
    foreach (Entry entry in _entries)
    {
      if (entry._content.Contains(keyword, StringComparison.OrdinalIgnoreCase))
      {
        foundEntries.Add(entry);
      }
    }

    if (foundEntries.Count > 0)
    {
      Console.WriteLine($"Found {foundEntries.Count} entries containing '{keyword}':");
      foreach (Entry entry in foundEntries)
      {
        entry.DisplayEntry();
      }
    }
    else
    {
      Console.WriteLine($"No entries found containing '{keyword}'.");
    }
  }
}