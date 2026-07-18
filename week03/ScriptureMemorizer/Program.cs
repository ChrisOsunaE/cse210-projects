// Exceeds the core requirements of the ScriptureMemorizer project by allowing the user to load a list of scriptures from a text file and randomly select one for memorization. The user can then hide words from the scripture and attempt to recall them.
using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary library = new ScriptureLibrary();
        library.LoadFromFile("scriptures.txt");
        Scripture scripture = library.GetRandomScripture(); 
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