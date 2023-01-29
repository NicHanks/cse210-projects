using System;
using System.IO;

public class Journal 
{
    public string fileName = "myFile.txt";
    List<Entry> entries = new List<Entry>();
    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void Load()
    {
        String line;
            {
            StreamReader sr = new StreamReader("myfile.txt");
            line = sr.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }
            sr.Close();
            Console.ReadLine();
            }
    }
    public void Save()
    {
        //fileName.Append(entries);
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine($"{entry._date}/ {entry._prompt}/ {entry._response}");
                 
            } 
        }
    }
    public void Display()
    {
            foreach (Entry entry in entries)
            {
            Console.WriteLine($"{entry._date} - {entry._prompt} \n {entry._response} \a");
            }
    }
}