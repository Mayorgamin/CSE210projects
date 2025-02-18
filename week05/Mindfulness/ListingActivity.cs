using System;
using System.Threading;
using System.Threading.Tasks; // Required for Task.Delay()

public class ListingActivity : Activity
{
    private List<string> _prompts;
    // Constructor initializes the listing activity and populates prompt
    public ListingActivity()
        : base("Listing", "\nThis activity will help you reflect on the good things in your \nlife by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>();
        InitialisePrompts();
    }
    // Runs the listing activity
    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();
        string prompt = GetRandomPrompt();

        Console.WriteLine("\nList as many responses as you can to the following prompt: ");
        Console.WriteLine($"\n--- {prompt} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue. ");

        // Waits for the user to press Enter before continuing
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        while (keyInfo.Key != ConsoleKey.Enter)
                {
                    Thread.Sleep(100);
                    keyInfo = Console.ReadKey(true);
                }

        Console.WriteLine("\nYou may begin in...");
        ShowCountdown(3);

        int itemCount = 0;
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        
        // Creates a new task to handle input without blocking execution
        Task inputTask = Task.Run(() =>
        {
            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                string response = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(response))
                {
                    itemCount++;    // Counts valid non-empty responses
                }
            }
        });

        // Waits for the time duration before proceeding
        Task.Delay(duration * 1000).Wait();

        Console.WriteLine($"\nYou listed {itemCount} items!");
        ShowSpinner(3);
        Thread.Sleep(500);
        DisplayEndingMessage();
    }

    private static Random _random = new Random();
    // Returns a random prompt from the list
    public string GetRandomPrompt()
    {
        return _prompts[_random.Next(_prompts.Count)];
    }

    // Initializes the list of prompts for reflection
    private void InitialisePrompts()
    {
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("What are some challenges you have overcome recently?");
        _prompts.Add("What are some things you are most grateful for today?");
        _prompts.Add("What small moments made you smile this week?");
        _prompts.Add("What are some ways you have helped others recently?");
        _prompts.Add("What are personal accomplishments you are proud of?");
        _prompts.Add("What are things you want to improve about yourself this year?");
        _prompts.Add("What are some experiences that have shaped your values?");
        _prompts.Add("What are times when faith has helped you in difficult moments?");
        _prompts.Add("Who are people that have positively influenced your life?");
    }
}
