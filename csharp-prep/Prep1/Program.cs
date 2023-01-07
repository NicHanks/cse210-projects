using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        Console.Write("What is your first name? ");
        string first = Console.ReadLine();
        Console.Write("What is your last name? ");
        string second = Console.ReadLine();

        Console.Write($"Your name is {second}, {first} {second}.");
    }
}