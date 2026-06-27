using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        string playAgain;
        do{
            int magicNumber;
            int userGuess;
            bool isCorrect = false;
            int attempts = 0;
            Random random = new Random();
            magicNumber = random.Next(101);

            do{
            Console.Write("Enter your guess: ");
            userGuess = int.Parse(Console.ReadLine());

            if (magicNumber > userGuess)
            {
                Console.WriteLine("Higher!");
            }
            else if (magicNumber < userGuess)
            {
                Console.WriteLine("Lower!");
            }
            else
            {
                Console.WriteLine("You guessed the magic number!");
                isCorrect = true;
            }
            attempts++;
            } while (!isCorrect);

            Console.WriteLine($"It took you {attempts} attempts to guess the magic number.");
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();

        } while (playAgain == "yes");
    }
}