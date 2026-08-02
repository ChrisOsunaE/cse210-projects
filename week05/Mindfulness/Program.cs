// Exceeding Requirements: The logging system is implemented in the LogManager class.
using System;


class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        while (choice != "5")
        {
            Console.Clear();
            Console.WriteLine("  1. Start Breathing Session");
            Console.WriteLine("  2. Start Reflection Session");
            Console.WriteLine("  3. Start Listing Session");
            Console.WriteLine("  4. View Activity Log");
            Console.WriteLine("  5. Quit");
            Console.Write("Choose an option: ");
            
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Activity breathing = new BreathingActivity();
                breathing.RunActivity();
            }
            else if (choice == "2")
            {
                Activity reflection = new ReflectionActivity();
                reflection.RunActivity();
            }
            else if (choice == "3")
            {
                Activity listing = new ListingActivity();
                listing.RunActivity();
            }
            else if (choice == "4")
            {
                LogManager logger = new LogManager();
                logger.DisplayLog();
            }
        }
    }
}