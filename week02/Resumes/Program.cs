using System;

class Program
{
    static void Main(string[] args)
    {
        // Create Job instances
        Job job1 = new Job
        {
            
            JobTitle = "Software Engineer",
            Company = "Microsoft",
            StartYear = 2019,
            EndYear = 2022
        };

        Job job2 = new Job
        {
            JobTitle = "Manager",
            Company = "Apple",
            StartYear = 2022,
            EndYear = 2023
        };

        Resume myResume = new Resume();
        myResume.Name = "Allison Rose";

        myResume.jobs.Add(job1);
        myResume.jobs.Add(job2);

        myResume.Display();
    }
}
