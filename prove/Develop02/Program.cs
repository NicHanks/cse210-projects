using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcom to the Journal Program!");
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        string input = Console.ReadLine();

        while (input != "5")
        {
            if (input == "1")
            {
                Journal.MakeNewEntry();
            }

            if (input == "2")
            {
                Journal.Display();
            }

            if (input == "3")
            {
                Journal.Load();
            }

            if (input == "4")
            {
                Console.WriteLine("What is the filename? ");
                string filename = Console.ReadLine();
                Journal.Save(filename);
            }
        }
        
        Console.WriteLine("Have a good day!");
    }
}