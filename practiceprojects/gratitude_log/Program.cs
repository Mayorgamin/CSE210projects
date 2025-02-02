using System;
using gratitude_log;

namespace Journal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Journal = new Journal();
            GratitudePrompts prompts = new GratitudePrompts();

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Write your own gratitude entry");
            Console.WriteLine("2. Respond to a random gratitude prompt");
            Console.WriteLine("3. View all gratitude entries");
            Console.WriteLine("4. Save entries to a file");
            Console.WriteLine("5. Load entries from a file");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter something you’re grateful for: ");
                    string gratitude = Console.ReadLine();
                    log.AddEntry(gratitude);
                    Console.WriteLine("Gratitude logged successfully!");
                    break;

                case "2":
                    string prompt = prompts.GetRandomPrompt();
                    Console.WriteLine($"Random Prompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    log.AddEntry(response);
                    Console.WriteLine("Gratitude logged successfully!");
                    break;

                case "3":
                    Console.WriteLine("\nGratitude Entries:");
                    log.DisplayEntries();
                    break;

                case "4":
                    Console.Write("Enter a filename to save to: ");
                    string saveFilename = Console.ReadLine();
                    log.SaveToFile(saveFilename);
                    break;

                case "5":
                    Console.Write("Enter a filename to load from: ");
                    string loadFilename = Console.ReadLine();
                    log.LoadFromFile(loadFilename);
                    break;

                case "6":
                    Console.WriteLine("Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
                }
            }
        }

    }
}

