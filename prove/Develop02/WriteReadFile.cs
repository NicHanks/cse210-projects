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
}