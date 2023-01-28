public class Entry
{
    public string date = "";
    public string prompt = "";
    public string response = "";

    public string GetDate()
    {
        DateTime dateTime = DateTime.Now; // will give the date for today
        string date = dateTime.ToString("mm/dd/yyyy");
        return date;
    }   

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
        this.response = entry;
    }

}