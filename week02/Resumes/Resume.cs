using System;

public class Resume
{
    public string Name;
    public List<Job> jobs = new List<Job>();


public void Display()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Jobs: ");
        foreach (var job in jobs)
        {
            job.Display();
        }
    }
}
