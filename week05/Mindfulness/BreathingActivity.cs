using System;
using System.Threading;

public class BreathingActivity : Activity
{
    // Constructor initialises the activity name and description
    public BreathingActivity() 
        : base("Breathing", "\nThis activity will help you relax by walking you through breathing  \nin and out slowly. Clear your mind and focus on your breathing." )
    {
    }
    public void Run()
    {
        
        int originalDuration = GetDuration();   // Stores original duration
        DisplayStartingMessage();               // Prompt user and set duration
        while (GetDuration() >0)                // Continues until session time is up
        {
            Console.Write("\nBreathe in... ");
            for (int i = 4; i >= 0; i--)        // Inhale countdown
            {
                Console.Write($"[{i}] ");
                Thread.Sleep(1000);
                Console.Write(new string('\b', 4)); // Clears previous number
            }
            Console.WriteLine();

            Console.Write("Breathe out... ");   
            for (int i = 6; i >= 0; i--)        // Exhale countdown
            {
                Console.Write($"[{i}] ");
                Thread.Sleep(1000);
                Console.Write(new string('\b', 4)); // Clears previous number
            }
            Console.WriteLine();
            SetDuration(GetDuration() - 10);    // Reduce remaining session time
        }
        DisplayEndingMessage();                 // // Shows completion message
    }
}