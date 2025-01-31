/* 
My program exceeds the requirements by:
- hidding only visible words
- handling punctutation while hiding words
- handling spaces while hiding words
*/

using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    class Program
    {
        // Define the Main method (entry point of the program)
        static void Main(string[] args)
        {
            // Display a welcome message to the user
            Console.WriteLine("Welcome to the Scripture Memorizer");
            Console.WriteLine("This program will help you memorize a scripture by gradually hiding words.");
            Console.WriteLine("Press ENTER to hide the words.");
            Console.WriteLine("Type 'quit' or press ESC to exit the program.");
            Console.WriteLine();
            // Create a reference object
            Reference reference = new Reference("1 Nephi", 3, 7);
            // Store the scripture text (example)
            string verseText = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
            // Create the scripture object
            Scripture scripture = new Scripture(reference, verseText);

            // Display the full scripture initially
            string getVerse = scripture.GetDisplayText();
            Console.WriteLine(getVerse);
            // Step 4: Enter a loop that repeatedly asks the user to press enter 
            // or type "quit" or press ESC to finish
            while(true)
            {
                // If all words are hidden, exit the loop
                if (scripture.AllWordsHidden())
                {
                    Console.WriteLine("All words are hidden. Well done!");
                    break; // Exit loop
                }
                Console.WriteLine();
                Console.WriteLine("Press ENTER to continue or type 'quit' or press ESC to finish: ");
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                // If the user presses ENTER, continue
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    scripture.HideRandomWords(3); // Hides 3 words per round
                    Console.Clear(); // Clear console
                    Console.WriteLine(scripture.GetDisplayText());
                }
                // If the user presses ESC, break out of the loop
                else if (keyInfo.Key == ConsoleKey.Escape)
                {
                    break; // Exit loop
                }
                // If the user types "quit", break out of the loop 
                else
                {
                    string userInput = Console.ReadLine(); //Read user input   
                    if (userInput.ToLower() == "quit")
                    {
                        break; // Exit loop
                    }

                }

            }
        // Display final message
        Console.WriteLine();
        Console.WriteLine("Thank you for using the Scripture Memorizer. Bye!");
        }
    }
}

