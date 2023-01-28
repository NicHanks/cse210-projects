using System;
using System.IO;

public class Journal 
{
    public string fileName = "myFile.txt";  //SAVING TO A FILE
    List<Entry> entries = new List<Entry>();
    public void AddEntry(Entry entry)
    {
        entries.Append(entry);
    }

    
    public void Save()
    {
        //fileName.Append(entries);
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine($"{entry.date} {entry.prompt} {entry.response}");
                 
            }
            
        }

    }

    //DISPLAYING ALL ENTRIES
    //System.IO.File.ReadAllLines();
    public void Display()
    {
            foreach (Entry entry in entries)      //This one is supposed to iterate through all Entry objects and call Entry's display
            {
            Console.WriteLine($"{entry.date} - {entry.prompt} \n {entry.response} \a");
            }
    }
    // ?Need?   var stringList = String.Join("\n", _entry.ToArray());
    // outputFile.WriteLine( stringList);)

    // using (StreamWriter outputFile = new StreamWriter(filename))
    // {
    //     // You can add text to the file with the WriteLine method
    //     outputFile.WriteLine("This will be the first line in the file.");

    //     // You can use the $ and include variables just like with Console.WriteLine
    //     string color = "Blue";
    //     outputFile.WriteLine($"My favorite color is {color}");
    // }

}