using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int number = -1;
        while (number != 0)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out number) && number != 0)
            {
                numbers.Add(number);
            }
            else if (number != 0)
            {
                Console.WriteLine("Please enter a valid integer.");
            }
        }
        if (numbers.Count > 0)
        {
            int sum = 0;
            int largest = numbers[0];
            int smallest = numbers[0];
            foreach (int num in numbers)
            {
                sum += num;
                if (num > largest)
                {
                    largest = num;
                }
                if (num < smallest && num > 0)
                {
                    smallest = num;
                }
            }
            double average = (double)sum / numbers.Count;
            // sorted list is:
            numbers.Sort();
            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average of the numbers is: {average}");
            Console.WriteLine($"The largest number is: {largest}");
            Console.WriteLine($"The smallest number is: {smallest}");
            Console.WriteLine("The sorted list is: " + string.Join(", ", numbers));
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}