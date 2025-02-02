using System;
using System.Collections.Generic;

namespace gratitude_log
{
    public class GratitudePrompts
    {
        // List to store gratitude prompts
        private List<string> prompts = new List<string>
        {
            "What made you smile today?",
            "Who are you grateful for in your life?",
            "What’s one thing you love about where you live?",
            "What’s a memory you cherish?",
            "What’s something you’re looking forward to?",
            "What’s one act of kindness you witnessed or received recently?",
            "What is a challenge you’re grateful for because it helped you grow?",
            "What’s your favorite activity or hobby, and why are you grateful for it?",
            "What’s a small but meaningful thing that happened today?",
            "What’s something in nature you’re grateful for?"
        };

        private Random random = new Random();

        // Method to get a random prompt
        public string GetRandomPrompt()
        {
            int index = random.Next(prompts.Count);
            return prompts[index];
        }
    }
}
