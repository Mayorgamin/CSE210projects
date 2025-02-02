using System;
using System.Collections.Generic;
using System.IO;

namespace gratitude_log
{
    public class GratitudeLog
    {
        // A list to store all gratitude entries
        private List<GratitudeEntry> entries = new List<GratitudeEntry>();

        // Method to add a new entry
        public void AddEntry(string text)
        {
            GratitudeEntry entry = new GratitudeEntry(text);
            entries.Add(entry);
        }

        // Method to display all entries
        public void DisplayEntries()
        {
            if (entries.Count == 0)
            {
                Console.WriteLine("No entries to display.");
                return;
            }

            foreach (var entry in entries)
            {
                Console.WriteLine(entry.ToString());
            }
        }

        // Method to save all entries to a file
        public void SaveToFile(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var entry in entries)
                {
                    writer.WriteLine(entry.ToString());
                }
            }
            Console.WriteLine($"Entries saved to {filename}");
        }

        // Method to load entries from a file
        public void LoadFromFile(string filename)
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine($"File {filename} does not exist.");
                return;
            }

            string[] lines = File.ReadAllLines(filename);
            entries.Clear(); // Clear existing entries before loading new ones
            foreach (string line in lines)
            {
                // Assume each line is formatted as "YYYY-MM-DD: Text"
                int separatorIndex = line.IndexOf(": ");
                if (separatorIndex > 0)
                {
                    string date = line.Substring(0, separatorIndex);
                    string text = line.Substring(separatorIndex + 2);
                    entries.Add(new GratitudeEntry(text) { Date = date });
                }
            }
            Console.WriteLine($"Entries loaded from {filename}");
        }
    }
}
