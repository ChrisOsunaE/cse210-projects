// I have exceeded the core requirements by adding the following features:
// 1. Multiple Journal Management: I created a JournalManager class that scans the working directory for existing .txt files
// 2. Persistent Custom Prompts: I added a Settings submenu that allows the user to add new writing prompts. 
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        JournalManger journalManager = new JournalManger();
        journalManager.DisplayAllJournals();    
        Console.Write("Enter the name of your journal: ");
        string journalName = Console.ReadLine();

        Journal journal = new Journal(journalName);
        journal.LoadFromFile();

        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save entries to a file");
            Console.WriteLine("4. Open another journal");
            Console.WriteLine("5. Display settings");
            Console.WriteLine("6. Quit");
            string choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Writing a new entry...");
                    PromptGenerator promptGenerator = new PromptGenerator();
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.WriteLine("Please write your entry:");
                    string entryText = Console.ReadLine();

                    Entry entry = new Entry
                    {
                        _dateTime = DateTime.Now,
                        _promptText = prompt,
                        _entryText = entryText
                    };

                    journal.AddEntry(entry);
                    break;

                case "2":
                    Console.WriteLine($"Displaying all entries from the journal {journal._journalName}...");
                    journal.DisplayAllEntries();
                    break;

                case "3":
                    Console.WriteLine("Saving entries...");
                    journal.SaveToFile();
                    break;

                case "4":
                    Console.WriteLine("Opening another journal...");
                    journalManager.DisplayAllJournals();
                    Console.Write("Enter the name of the journal to open: ");
                    string newJournalName = Console.ReadLine();
                    journal = new Journal(newJournalName);
                    journal.LoadFromFile();
                    break;

                case "5":
                    bool inSettingsMenu = true;
                    PromptGenerator settingsPromptGenerator = new PromptGenerator();
                    while(inSettingsMenu)
                    {
                        Console.WriteLine("\n-- Settings Menu --");
                        Console.WriteLine("1. Display all prompts");
                        Console.WriteLine("2. Add a new prompt");
                        Console.WriteLine("3. Return to main menu");
                        Console.Write("Enter your choice: ");
                        string settingsChoice = Console.ReadLine();

                    Console.Clear();

                    switch (settingsChoice)
                    {
                        case "1":
                            PromptGenerator promptGen = new PromptGenerator();
                            promptGen.DisplayAllPrompts();
                            break;

                        case "2":
                            Console.Write("Enter the new prompt: ");
                            string newPrompt = Console.ReadLine();
                            settingsPromptGenerator.AddNewPrompt(newPrompt);
                            settingsPromptGenerator.SavePromptsToFile();
                            break;

                        case "3":
                            Console.WriteLine("Returning to main menu...");
                            inSettingsMenu = false;
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Returning to main menu...");
                            break;
                        }
                    }

                    break;

                case "6":
                    Console.WriteLine("Quitting the program.");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }while (true);
    }
}