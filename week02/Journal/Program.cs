using System;
using System.Collections.Generic;
using journal; //For working with lists

namespace Journal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Journal myJournal = new Journal();
            PromptGenerator myPromptgenerator = new PromptGenerator();
            Console.WriteLine("\nWelcome to the Journal Program");

            while (true)
            {   //Display menu options
                
                Console.WriteLine("\nPlease select one of the following choices:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
                
                Console.Write("What would you like to do? ");
                string userInput = Console.ReadLine();

                //convert input from string to integer
                if (int.TryParse(userInput, out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            string prompt = myPromptgenerator.GetRandomPrompt();
                            Console.WriteLine($"{prompt}");
                            string response = Console.ReadLine();
                            //Create new entry and add to the journal
                            Entry newEntry = new Entry(response, prompt, DateTime.Now.ToString("yyyy-MM-dd"));
                            myJournal.AddEntry(newEntry);
                            break;
                        
                        case 2:
                            Console.WriteLine("");
                            myJournal.DisplayAll();
                            break;

                        case 3:
                            Console.WriteLine("What is the filename? ");
                            string loadFilename = Console.ReadLine();
                            myJournal.LoadFromFile(loadFilename);
                            break;
                        
                        case 4:
                            Console.Write("What is the filename? "); 
                            string saveFilename = Console.ReadLine();
                            myJournal.SaveToFile(saveFilename);
                            break;  

                        case 5:
                            Console.WriteLine("");
                            return;
                        
                        default:
                            break;

                    }

                }
            }
        }
    }
}