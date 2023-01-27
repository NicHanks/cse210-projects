//using Systems.Collections.Generic; //? Idk if this is correct, I got it off of ms teams

public class Journal 
{
    //ATTRIBUTES
    List<string> _entries = List<string>; 


    //ADDING TO AN ENTRY
    //I need to store the entries as objects in a list w datetype List<Entry>
    public void Add()
    {
        
    }

    //DISPLAYING ALL ENTRIES
    //This one is supposed to iterate through all Entry objects and call Entry's display
    //Not sure if this is supposed to be like get all the objects then call display
    //or call display for each object- one at a time per se. 
    System.IO.File.ReadAllLines()
    foreach (string entry in File(Entry))
    {
        Console.WriteLine(Entry.Display());
    }

    //SAVING TO A FILE
    // ?Need?   var stringList = String.Join("\n", _entry.ToArray());
    // outputFile.WriteLine( stringList);)
    string fileName = "myFile.txt";

    using (StreamWriter outputFile = new StreamWriter(filename))
    {
        // You can add text to the file with the WriteLine method
        outputFile.WriteLine("This will be the first line in the file.");

        // You can use the $ and include variables just like with Console.WriteLine
        string color = "Blue";
        outputFile.WriteLine($"My favorite color is {color}");
    }

    //Loading from a file
    string filename = "myFile.txt";
    string[] lines = System.IO.File.ReadAllLines(filename);

    foreach (string line in lines)
    {
        string[] parts = line.Split(",");

        string firstName = parts[0];
        string lastName = parts[1];
    }
}