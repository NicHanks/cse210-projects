using System.IO;

public class WriteReadFile
{
    string filename = "myFile.txt";
    public void ReadTextfile()
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string firstName = parts[0];
            string lastName = parts[1];
        }
    }

    using (StreamWriter outputFile = new StreamWriter(filename))
    {
        // You can add text to the file with the WriteLine method
        outputFile.WriteLine("This will be the first line in the file.");

        // You can use the $ and include variables just like with Console.WriteLine
        string color = "Blue";
        outputFile.WriteLine($"My favorite color is {color}");
    }
}