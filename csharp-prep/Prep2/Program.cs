using System;

class Program
{
    static void Main(string[] args)
    {
        //this is prep 2
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int intGrade = int.Parse(grade);
        string finalGrade = "";
        if (intGrade >= 90)
        {
            finalGrade = "A";
        }
        else if (intGrade >= 80)
        {
            finalGrade = "B";
        }
        else if (intGrade >= 70)
        {
            finalGrade = "C";
        }
        else
        {
            finalGrade = "F";
        }
        Console.WriteLine($"your grade is {finalGrade} ");
    }

}