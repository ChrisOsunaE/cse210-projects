public class Entry
{
  public string _date;

  public string _content;

  public string _prompt;

  public string GeneratePrompt()
  {
    string[] prompts = {
            "What was the best part of my day?",
            "What am I grateful for today?",
            "What did I learn today?",
            "What made me smile today?",
            "What challenges did I face today?",
            "Who was the most interesting person I interact today?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is something I want to remember about today?",
            "What is something I want to let go of?",
        };

    Random random = new Random();
    int index = random.Next(prompts.Length);
    return prompts[index];
  }

  public void DisplayEntry()
  {
    Console.WriteLine($"Date: {_date}:: {_prompt}");
    Console.WriteLine($"Content: {_content}");
    Console.WriteLine();
  }

  public void CreateEntry()
  {
    _date = DateTime.Now.ToString("yyyy-MM-dd");

    _prompt = GeneratePrompt();
    Console.WriteLine($"Date {_date}:: Prompt: {_prompt}");

    Console.WriteLine("Please enter your response: ");
    _content = Console.ReadLine();
  }
}