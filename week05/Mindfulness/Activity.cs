using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;

public class Activity
{
    //Fields to store activity name, description,durations
    private string _name;
    private string _description;
    private int _duration;
    private int _originalDuration; // Stores the original duration for reference

    // Constructor to initialise activity name and description
    public Activity(string name, string description)
   {
    _name = name;
    _description = description;
   } 

    // Getters and setters for duration
    public int GetDuration()
    {
        return _duration;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;   
    }
        public int GetOriginalDuration()    
    {
        return _originalDuration;       // Returns the originally set duration
    }
    public void SetOriginalDuration(int originalDuration)
    {
        _originalDuration = originalDuration; // Stores the original duration
    }
    // Displays the introduction message and prompts user for duration
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"\nWelcome to the {_name} Activity.");
        Thread.Sleep(2000);
        Console.WriteLine($"{_description}\n");
        Thread.Sleep(4000);
        Console.WriteLine($"How long, in seconds, would you like for your session? \n");
        Thread.Sleep(1000);
    
        int duration;
        // Gets input as string and converts to integer. Ensures only positive numbers. 
        while (!int.TryParse(Console.ReadLine(), out duration)||duration <= 0) // Loops until a valid positive number entered
        {
            Console.Write("Please enter a valid number ");
        }
        SetDuration(duration); // Stores the validated duration
        SetOriginalDuration(duration); // Stores the original duration for later reference
        
        Console.WriteLine("Get ready...");
        Console.WriteLine();
        ShowSpinner(2);
    }
    // Displays the ending message with session summary
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!\n");
        Console.WriteLine($"You have completed {GetOriginalDuration()} seconds of the {_name} Activity.");
        ShowSpinner(1);
    }
    // Method that creates spinner animation for the specified duration 
    public void ShowSpinner(int seconds)
    {
        char [] spinner = {'|', '/', '-', '\\'}; // Characters for spinner effect
        for (int i = 0; i < seconds * 5; i++) // Loops to animate spinner
        {
            Console.Write(spinner[i % 4]); // Displays spinner frame
            Thread.Sleep(200); // Pauses before updating
            Console.Write("\b"); // Erases last character before printing the next one
        }
    }
    // Method that creates a countdown for the specified duration
    public void ShowCountdown(int seconds)
    {
        int counter = seconds; // Initializes countdown counter
        while (counter > 0) // Loops until counter reaches 1
        {
            Console.WriteLine($"{counter}");
            counter--; // Decreases the counter by 1
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}


