/*
Exceding core requirements:
- Used Task.Run() in ListingActivity to prevent blocking execution.
- Input validations to prevent crashes.
- Used dictionaries in RefelectingActivity to provide themed prompts and themed questions.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;            // Controls the main menu loop
        
        while (running)
        {
            // Displays menu options
            Console.WriteLine("\nMenu");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu: ");

            // Validates user input as an integer between 1 and 4
            int choice;
            bool isValid  = int.TryParse(Console.ReadLine(), out choice);
            if (!isValid || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid input. Enter a number between 1 and 4.");
                continue;               // Restarts the loop without executing an activity
            }

            // Execute the selected activity
            if (choice == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            else if (choice == 2)
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }
            else if (choice == 3)
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }
            else if (choice == 4)
            {
                running= false;         // Exits the loop to quit program
            }

            // Ensures the user presses Enter to return to the menu
            if (choice != 4)
            {
                Console.WriteLine("\nPress Enter to return to the menu...");
                Console.ReadLine();     // Prevents unintended extra input
            }
        }
    }   
}