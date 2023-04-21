using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? " );
        int gradePercentage = int.Parse( Console.ReadLine() );

        string gradeLetter = "";
        if (gradePercentage > 90 )
        {
            gradeLetter = "A";
        }
        else if (gradePercentage >= 80 )
        {
            gradeLetter = "B";
        }
        else if (gradePercentage >= 70 )
        {
            gradeLetter = "C";
        }
        else
        {
            gradeLetter = "F";
        }

        
        int lastDigit = gradePercentage % 10;
        string gradeSign = "";
        
        if (gradeLetter != "F" && lastDigit >= 7)
        {
            gradeSign = "+";
        }
        else if (gradeLetter != "F" && lastDigit < 3)
        {
            gradeSign = "-";
        }
        
        if (gradeLetter == "A" && lastDigit < 3)
        {
            gradeSign = "";
        }
        else if (gradeLetter == "F")
        {
            gradeSign = "";
        }

        Console.WriteLine($"Your grade is {gradeLetter}{gradeSign}");

        if (gradeLetter != "F")
        {
            Console.WriteLine($"COngratulations, you pass the course!");
        }
        else 
        {
            Console.WriteLine($"Better luck next time.");
            
        }
        
        
        
    }
}