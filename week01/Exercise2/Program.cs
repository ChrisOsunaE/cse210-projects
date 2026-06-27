using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        int gradePercentage;
        bool passed;
        char letter;
        int lastDigit;
        char sign;

        Console.WriteLine("What was your grade percentage (0-100)?");
        gradePercentage = int.Parse(Console.ReadLine());

        if (gradePercentage >= 90)
        {
            letter = 'A';
            passed = true;
        }
        else if (gradePercentage >= 80)
        {
            letter = 'B';
            passed = true;
        }
        else if (gradePercentage >= 70)
        {
            letter = 'C';
            passed = true;
        }
        else if (gradePercentage >= 60)
        {
            letter = 'D';
            passed = false;
        }
        else
        {
            letter = 'F';
            passed = false;
        }

        lastDigit = gradePercentage % 10;
        if (lastDigit >= 7)
        {
            sign = '+';
        }
        else if (lastDigit <= 3)
        {
            sign = '-';
        }
        else
        {
            sign = ' ';
        }
        
        switch (letter)
        {
        case 'F':
            sign = ' ';
            break;
        case 'A':
            if (sign == '+')
            {
                sign = ' ';
            }
            break;
        }

        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        if (passed)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("Try harder, and don't give up.");
        }

    }
}