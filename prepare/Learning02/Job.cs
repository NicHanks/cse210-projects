public class Job
{
    public string _jobTitle = "";
    public string _companyName = "";
    public int _startDate = 0;
    public int _endDate = 0;
    public Job()
    {
    }
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_startDate}-{_endDate}");
    }
    public void ShowJobTitle()
    {
        Console.WriteLine($"{_jobTitle}");
    }
    public void ShowCompanyName()
    {
        Console.WriteLine($"{_companyName}");
    }
}