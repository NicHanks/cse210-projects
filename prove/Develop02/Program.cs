using System.Collections.Generic;

namespace Develop02
{
    class Program
    {
        static void Main(string[] args)
        {

            Journal journal = new Journal(); 
            PromptGenerator promptGenerator = new PromptGenerator(); 
            string input = "0";

            while (input != "5")
            {
                Console.WriteLine("Welcome to the Journal Program!");
                Console.WriteLine("Please select one of the following choices:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
                input = Console.ReadLine();

                if (input == "1") 
                {               
                    Entry entry = new Entry();
                    string date = entry.GetDate();
                    string prompt = promptGenerator.GetPrompt(); 
                    Console.WriteLine($"Date : {date} - Prompt: {prompt}");
                    string _entry = Console.ReadLine();
                    entry.SetDate(date);
                    entry.SetPrompt(prompt);
                    entry.SetUserEntry(_entry);
                    journal.AddEntry(entry);
                    
                }

                if (input == "2")
                {
                    journal.Display();
                }

                if (input == "3")
                {
                    journal.Load();
                    //string[] lines = System.IO.File.ReadAllLines();
                }

                if (input == "4")
                {
                    Console.WriteLine("What is the filename? ");
                    journal.fileName = Console.ReadLine();
                    journal.Save();
                }
            }
            
            Console.WriteLine("Have a good day!");
        }
    }
}
