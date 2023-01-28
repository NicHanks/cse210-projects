using System;

public class Journal 
{
    List<Entry> journal = new List<Entry>();
    public void AddEntry(Entry entry)
    {
        journal.Append(entry);
    }

    
    public void Save(Journal journal)
    {
        filename.Append(journal);
    }

    //DISPLAYING ALL ENTRIES
    //System.IO.File.ReadAllLines();
    public void Display()
    {
            foreach (List<Entry> in journal)      //This one is supposed to iterate through all Entry objects and call Entry's display
            {
            Console.WriteLine(Entry.Display(journal));
            }
    }
    // ?Need?   var stringList = String.Join("\n", _entry.ToArray());
    // outputFile.WriteLine( stringList);)
    string fileName = "myFile.txt";  //SAVING TO A FILE

    // using (StreamWriter outputFile = new StreamWriter(filename))
    // {
    //     // You can add text to the file with the WriteLine method
    //     outputFile.WriteLine("This will be the first line in the file.");

    //     // You can use the $ and include variables just like with Console.WriteLine
    //     string color = "Blue";
    //     outputFile.WriteLine($"My favorite color is {color}");
    // }

    string filename = "myFile.txt";     //Loading from a file
    string[] lines = System.IO.File.ReadAllLines(filename);

    foreach (string line in lines)
    {
        string[] parts = line.Split(",");

        string firstName = parts[0];
        string lastName = parts[1];
    }
}