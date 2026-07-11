public class Entry
{
    public DateTime _dateTime;
    public string _promptText;
    public string _entryText;

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_dateTime}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine("------------------------------");
    }

    public void parseEntry(string line)
    {
        string[] parts = line.Split('|');
        if (parts.Length == 3)
        {
            _dateTime = DateTime.Parse(parts[0]);
            _promptText = parts[1];
            _entryText = parts[2];
        }
    }

}