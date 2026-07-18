using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        string input = "";

        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        do
        {   
            Console.Clear();
            Console.WriteLine(scripture.GetReference().DisplayReference() + scripture.DisplayText());
            Console.WriteLine("Write 'quit' to exit.");
            input = Console.ReadLine();
            if (input != "quit")
            {
                scripture.HideRandomWords(3);
            }

        } while (input != "quit" && !scripture.AllWordsHidden());

        if (scripture.AllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetReference().DisplayReference() + scripture.DisplayText());
            Console.WriteLine("All words are hidden. Good job!");
        }
    }
}