using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAssignment = new MathAssignment("Luis Vega", "Algebra", "Section 1.1", "1-5");
        WritingAssignment writingAssignment = new WritingAssignment("The Impact of the bitcoin", "Luis Vega", "Economics");
        string summary = mathAssignment.GetSummary();
        string homeworkList = mathAssignment.GetHomeworkList();
        string writingHomework = writingAssignment.GetWritingInformation();
        Console.WriteLine(homeworkList);
        Console.WriteLine(summary);
        Console.WriteLine(writingHomework);
        

    }
}