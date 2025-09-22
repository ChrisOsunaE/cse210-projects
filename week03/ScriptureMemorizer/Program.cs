using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Scripture Memorizer Program");
        
        // Ejemplo con Proverbios 3:5-6
        Reference reference = new Reference("Psalm", 8, 4, 5);
        string texto = "What is man, that thou art mindful of him? and the son of man, that thou visitest him? For thou hast made him a little lower than the angels, and hast crowned him with glory and honour.";
        
        Scripture scripture = new Scripture(reference, texto);

        RunMemorizer(scripture);
    }

    static void RunMemorizer(Scripture scripture)
    {
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide 3 random words, or type 'quit' to exit.");
            
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3);
        }

        if (scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\n¡Everything is hidden! You have memorized the scripture!");
        }
    }
}