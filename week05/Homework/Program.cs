using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        Assignment a1 = new Assignment("Peter Parker", "Web Development");
        Console.WriteLine(a1.GetSummary());
        Console.WriteLine();

        MathAssignment a2 = new MathAssignment("Clark Kent", "Algebra", "Section 5.2", "1-10");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment a3 = new WritingAssignment("Bruce Wayne", "Literature", "The Dark Knight");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}