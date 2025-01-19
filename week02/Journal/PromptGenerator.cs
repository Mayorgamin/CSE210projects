using System;

namespace journal
{
    public class PromptGenerator
    {
        public List<string> _prompts;
        public Random _random;

        //constructor to initialise _prompts and random
        public PromptGenerator()
        {
            _prompts = new List<string>()
           
            {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?",
                "What moment today made me feel the most fulfilled?",
                "Who or what inspired me today?",
                "What challenge did I face today, and how did I overcome it?",
                "What is one thing I learned today that I want to remember?",
                "If I could relive one part of my day, which would it be and why?"
            };
            //initialise _random in the constructor
            _random = new Random();
        }
                   
        // Method to get a random prompt
        public string GetRandomPrompt()
        {
            int index = _random.Next(_prompts.Count);
            return _prompts[index];
        }
    }
}