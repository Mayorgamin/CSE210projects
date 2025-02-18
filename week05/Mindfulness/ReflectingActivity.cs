using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private Dictionary<string, List<string>> _themedPrompts;
    private Dictionary<string, List<string>> _themedQuestions;
    private string _selectedPrompt;

    public ReflectingActivity()
        : base("Reflecting", "\nThis activity will help you reflect on meaningful moments in your life. \nYou will consider experiences that shaped you, recognize personal growth, \nand explore ways to apply what you've learned.")
        {
            _themedPrompts = new Dictionary<string, List<string>>();
            _themedQuestions = new Dictionary<string, List<string>>();
            InitialisePromptsAndQuestions();
        }
    // Method to run the Reflecting Exercise
    public void Run()
    {
        // Stores the original duration to display at the end
        
        _selectedPrompt = GetRandomPrompt();

        // Methods that display the prompts and the questions
        DisplayStartingMessage();
        DisplayPrompt();
        Console.WriteLine("\nWhen you have something in mind, press enter to continue. ");

        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        while (keyInfo.Key != ConsoleKey.Enter)
                {
                    Thread.Sleep(100);
                    keyInfo = Console.ReadKey(true);
                }
        Console.WriteLine("Now ponder on the following 4 question(s). \nFeel free to reflect on the one or ones that you prefer: ");
        ShowCountdown(3);

        int originalDuration = GetDuration();

        List<string> questions = _themedQuestions[_selectedCategory];

        for (int i = 0; i < 4; i++)
        {
            if (GetDuration() <= 0) break;

            DisplayQuestions(questions[i]);
            SetDuration(GetDuration() -1);
        }
        while (GetDuration() > 0)
        {
            Thread.Sleep(1000);
            SetDuration(GetDuration() -1);
        }
        Thread.Sleep(5000);

        //while (GetDuration() > 0)
        //{
        //    DisplayQuestions();
        //    SetDuration(GetDuration());
        //}
        DisplayEndingMessage();
        ShowSpinner(3);

        // Prints final message and summarises the time of the session
    //    Console.WriteLine("Well done!!");
    //    Console.WriteLine();
    //    Console.WriteLine($"You have completed {originalDuration} seconds of the Reflecting Activity.");
    //    ShowSpinner(3); // Spinner to create a smooth transition to the menu
    }
    private static Random _random = new Random(); // Shared instance of random 
    private string _selectedCategory;

    public string GetRandomPrompt()
    {
        List<string> categories = _themedPrompts.Keys.ToList();
        _selectedCategory = categories[_random.Next(categories.Count)];

        List<string> promptsInCategory = _themedPrompts[_selectedCategory];
        string randomPrompt = promptsInCategory[_random.Next(promptsInCategory.Count)];
        return randomPrompt;
    }
//    public string GetRandomQuestion()
//    {
//        List<string> questionsInCategory = _themedQuestions[_selectedCategory];
//        string randomQuestion= questionsInCategory[_random.Next(questionsInCategory.Count)];
//        return randomQuestion;
//    } 

    public void DisplayPrompt()
    {
        Console.WriteLine("\n---Consider the following prompt: ---\n");
        Thread.Sleep(2000);
        Console.WriteLine($"\"{_selectedPrompt}\"");
        Thread.Sleep(2000);
    }

    public void DisplayQuestions(string question)
    {
        //Console.WriteLine("\n---Reflect on the following questions: ---");
        Thread.Sleep(200);
        //Console.WriteLine(GetRandomQuestion());
        Console.WriteLine($"\n{question}");
        Thread.Sleep(200);
    }


    // Helper method to initialise promts and questions
    public void InitialisePromptsAndQuestions()
    {
        _themedPrompts = new Dictionary<string, List<string>>
        {
            
            {"Gratitude and appreciation", new List<string>
                {"Think of a time when you felt truly grateful for something or someone.",
                "Recall a moment when you were deeply moved by someone’s kindness.",
                "Describe an experience that reminded you of the good in people.",
                "Think of a time when you paused to appreciate life’s small joys."}
            },
            {"Connection and Relationships", new List<string>
                {"Think of a time when someone supported you in a difficult moment.",
                "Describe a moment when you felt truly connected to another person.",
                "Recall a time when a friendship or family bond strengthened.",
                "Think of an act of kindness that strengthened a relationship in your life."}
            },
            {"Overcoming Challenges", new List<string>
                {"Think of a time when you did something really difficult.",
                "Recall a moment when you faced a challenge and persevered.",
                "Describe a situation where you had to step out of your comfort zone.",
                "Think of a time when you felt like giving up but kept going."}
            }
        };
    
        
        _themedQuestions = new Dictionary<string, List<string>>
        {
            {"Gratitude and appreciation", new List<string>
                {"What are some things you are most grateful for?",
                "How has this moment impacted your appreciation for life?",
                "Who are the people in your life that you value the most?",
                "How can you express gratitude more often in your daily life?"}
            },
            
            {"Connection and Relationships", new List<string>
                {"What makes this relationship special?",
                "How has this person impacted your life?",
                "What can you do to strengthen your relationships further?",
                "How can you show appreciation for the people in your life?"}
            },
            {"Overcoming Challenges", new List<string>
                {"What obstacles did you face in this situation?",
                "How did you stay motivated despite difficulties?",
                "What strengths did you develop by overcoming this challenge?",
                "How has this experience shaped your approach to future challenges?"}
            }
        };  
    }
}


