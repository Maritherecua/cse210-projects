using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of  base Assignment object and print the summary
        Assignment a1 = new Assignment("Student A", "Graphs");
        Console.WriteLine(a1.GetSummary());

        // Create an instance of the derived class Assignments
        MathAssignment a2 = new MathAssignment("Student B", "Algebra", "Section 1.2", "Problems 1-10");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Student C", "History", "Napoleon rises to power");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}