using System;

namespace gratitude_log
{
    public class GratitudeEntry
    {
        // Property for storing the gratitude text
        public string Text { get; set; }

        // Property for storing the date of the entry
        public string Date { get; set; }

        // Constructor to initialize the entry with text and the current date
        public GratitudeEntry(string text)
        {
            Text = text;
            Date = DateTime.Now.ToString("yyyy-MM-dd");
        }

        // Override ToString to provide a formatted string representation of the entry
        public override string ToString()
        {
            return $"{Date}: {Text}";
        }
    }
}
