public class Entry
{
    public string _date = "";
    public string _prompt = "";
    public string _scripture = "";
    public string _response = "";

    public string GetDate()
    {
        DateTime dateTime = DateTime.Now;
        string _date = dateTime.ToString("mm/dd/yyyy");
        return _date;
    }   

    public void SetDate(string date)
    {
        this._date = date;
    }
    public void SetPrompt(string prompt)
    {
        this._prompt = prompt;
    }
    public void SetScripture(string scripture)
    {
        this._scripture = scripture;
    }
    public void SetUserEntry(string entry)
    {
        this._response = entry;
    }

}