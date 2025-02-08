using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment myAssignment = new Assignment("Francisco Mayorga", "Chemistry");
        string summary = myAssignment.GetSummary();
        Console.WriteLine("Assignment Summary:");
        Console.WriteLine(summary);

        MathAssignment myMathAssignment = new MathAssignment("Carolina Astorga", "Geometry", "6.9", "2 * 5");
        string summaryMath = myMathAssignment.GetHomeworkList();
        Console.WriteLine("\nMath Assignment:");
        Console.WriteLine(summaryMath);

        WritingAssignment myWritingAssignment = new WritingAssignment("Owain Hayles", "Spanish", "La Consagración");
        string summaryWriting = myWritingAssignment.GetWritingInformation();
        Console.WriteLine("\nWriting Assignment:");
        Console.WriteLine(summaryWriting);

    }
}

