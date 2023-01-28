using System.Collections.Generic;

namespace Develop02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            string input = Console.ReadLine();

            // List<Journal> Entries = New List<Journal>();
            List<Entry> variable_name = new List<Entry>(); 
            PromptGenerator promptGenerator = new PromptGenerator(); 

            while (input != "5")
            {
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
                    Journal journal = new Journal();
                    journal.Save(entry);
                    List<Entry> entries = new List<Entry>();
                    
                }

                if (input == "2")
                {
                    Journal.Display();
                }

                if (input == "3")
                {
                    Journal.Load();
                    string[] lines = System.IO.File.ReadAllLines();
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
}
