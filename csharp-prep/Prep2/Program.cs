using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What Grade did you get? ");
        string stringGrade = Console.ReadLine();
        int grade = int.Parse(stringGrade);
        string letter = "";
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is {letter}.");
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You Passed! ");
        }
        else 
        {
            Console.WriteLine("Try again next time!");
        }
    }
}