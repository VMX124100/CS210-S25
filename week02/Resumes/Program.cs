using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job("Software Engineer", "Lex Corp", 2015, 2020);
        Job job2 = new Job("Senior Developer", "Web Os Company", 2020, 2023);
        Job job3 = new Job("Project Manager (Hostage)", "Global Tech North Korea", 2023, 2999);

        Resume my_resume = new Resume();
        my_resume._name = "David Martinez";
        my_resume._jobs.Add(job1);
        my_resume._jobs.Add(job2);
        my_resume._jobs.Add(job3);
        
        my_resume.DisplayResume();
    }
}