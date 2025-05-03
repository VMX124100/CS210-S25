using System;

class Job
{
    string _company { get; set; }
    int _yearStarted { get; set; }
    int _yearEnded { get; set; }
    string _title { get; set; }


    public Job(string title, string company, int yearStarted, int yearEnded)
    {
        _title = title;
        _company = company;
        _yearStarted = yearStarted;
        _yearEnded = yearEnded;
    }

    public void DisplayJobInfo()
    {
        Console.WriteLine($"Title: {_title}, Company: {_company}, Years: {_yearStarted} - {_yearEnded}");
        Console.WriteLine();
    }
}