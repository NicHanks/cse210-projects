using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squaredNumber = SquareNumber(number);
        DisplayResult(name, squaredNumber);


        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName()
        {
            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.WriteLine("What is your favorite number? ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        // ?
        static int SquareNumber(int num)
        {
            int squared = num * num;
            return squared;
        }
        static void DisplayResult(string name, int squaredNumber)
        {
            Console.WriteLine($"Brother {name}, the square of your number is {squaredNumber}");
        }

    }
}