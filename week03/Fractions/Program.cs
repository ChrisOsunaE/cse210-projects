using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        Fraction fraction1 = new Fraction(6, 8);

        Console.WriteLine("Default Fraction: " + fraction1.GetFractionString());
        Console.WriteLine("Decimal Value: " + fraction1.GetDecimalValue());

        fraction1.SetTop(2);
        fraction1.SetBottom(4);
        Console.WriteLine("Updated Fraction: " + fraction1.GetFractionString());
        Console.WriteLine("Updated Decimal Value: " + fraction1.GetDecimalValue());
    }
}