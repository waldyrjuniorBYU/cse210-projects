using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your percentage grade? 0-100");
        string percentGrade = Console.ReadLine();
        int gradeTextToNumber = int.Parse(percentGrade);
        string letterGrade;

        if (gradeTextToNumber >= 90)
        {
            letterGrade = "A";
        }
        else if (gradeTextToNumber >= 80 && gradeTextToNumber < 90)
        {
            letterGrade = "B";
        }
        else if (gradeTextToNumber >= 70 && gradeTextToNumber < 80)
        {
            letterGrade = "C";
        }
        else if (gradeTextToNumber >= 60 && gradeTextToNumber < 70)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }
        Console.WriteLine($"Your letter Grade is {letterGrade}.");
        if (gradeTextToNumber >= 70)
        {
            Console.WriteLine($"Congrats.");
        }
        else
        {
            Console.WriteLine($"Next Time.");
        }
    }
}