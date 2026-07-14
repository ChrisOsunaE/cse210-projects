public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "How did I see the hand of God in my life today?",
        "What was the best part of my day?",
        "What am I grateful for today?",
        "What is something I can do to make someone else's day better?"
    };

    public PromptGenerator()
    {
        LoadPromptsFromFileIfExists();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public void AddNewPrompt(string prompt)
    {
        _prompts.Add(prompt);
        Console.WriteLine("New prompt added successfully.");
    }

    public void DisplayAllPrompts()
    {
        Console.WriteLine("Displaying all prompts...");
        foreach (var prompt in _prompts)
        {
            Console.WriteLine(prompt);
        }
    }

    public void SavePromptsToFile()
    {
      string filename = "prompts.txt";
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var prompt in _prompts)
            {
                writer.WriteLine(prompt);
            }
        }
        Console.WriteLine($"Prompts saved to {filename} successfully.");
    }

    public void LoadPromptsFromFileIfExists()
    {
        string filename = "prompts.txt";
        if (File.Exists(filename))
        {
            _prompts.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    _prompts.Add(line);
                }
            }
            
            Console.WriteLine($"Prompts loaded from {filename} successfully.");
            System.Threading.Thread.Sleep(3000); 
            Console.Clear(); 


        }
    }
}