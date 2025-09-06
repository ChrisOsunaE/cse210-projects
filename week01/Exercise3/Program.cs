using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random random = new Random();
        int magicNumber = random.Next(1, 101);

        Console.WriteLine("Guess a number between 1 and 100.");
        Console.WriteLine("Enter 0 to quit.");
        int count = 0;
        while (true)
        {
            count++;
            Console.WriteLine($"Guess number {count}");

            Console.Write("What is your guess? ");
            int guess = Convert.ToInt32(Console.ReadLine());

            if (guess == 0)
            {
                break;
            }

            if (guess < magicNumber)
            {
                Console.WriteLine("Too low!");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Too high!");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed the magic number.");
                break;
            }
            Console.WriteLine($"You have made {count} guesses.");
        }
    }
}