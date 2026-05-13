using System;

class Program
{
    static void Main(string[] args)
    {
        // Parent class for the overall summary
        Assignment a = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(a.GetSummary());

        // math child class that pulls from both MathAssignment and Assignment
        MathAssignment m = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(m.GetSummary());
        Console.WriteLine(m.GetHomeworkList());

        // Writing child class that pulls also from Assignment, but from Writing Assignment instead of Math Assignment
        WritingAssignment w = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(w.GetSummary());
        Console.WriteLine(w.GetWritingInformation());
        
    }
}