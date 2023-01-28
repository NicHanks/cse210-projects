public class Entry
{
    public string GetDate()
    {
        DateTime dateTime = DateTime.Now; // will give the date for today
        string date = dateTime.ToString("mm/dd/yyyy");
        return date;
    }   

    string date = "";
    string prompt = "";
    string entry = "";

    public void SetDate(string date)
    {
        this.date = date;
    }
    public void SetPrompt(string prompt)
    {
        this.prompt = prompt;
    }
    public void SetUserEntry(string entry)
    {
        this.entry = entry;
    }

    
}