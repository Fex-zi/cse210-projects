using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a base "Assignment" object
        Assignment num1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(num1.GetSummary());

        // Now create the derived class assignments
        MathAssignment num2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(num2.GetSummary());

        WritingAssignment num3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(num3.GetSummary());
    }
}




