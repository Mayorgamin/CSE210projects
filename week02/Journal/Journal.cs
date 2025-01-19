using System;
using System.Collections.Generic;
using System.IO;
using journal;

namespace Journal
{
    public class Journal
    {
        // List to store the entries
        public List<Entry> _entries;

        // constructor to initialise the _entries list
        public Journal()
        {
            _entries = new List<Entry>();
        }
        
        // Method to add a new journal entry
        public void AddEntry(Entry newEntry)
        {
            _entries.Add(newEntry);
        }
       
        // Method to display the entries
        public void DisplayAll()
        {
            if (_entries.Count == 0)
            {
                Console.WriteLine("No entries to display.");
                return;
            }
            foreach (Entry entry in _entries)
            {
                Console.WriteLine($"Date: {entry._date} - Prompt: {entry._promptText}");
                Console.WriteLine($"{entry._entryText}");
            }
        }

        // Method to save the entries
        public void SaveToFile(string file)
        {
            using (StreamWriter outputFile = new StreamWriter(file))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine(entry.ToString());
                }
             }            
        }

        public void LoadFromFile(string file)
        {
            string[] lines = System.IO.File.ReadAllLines(file);
            foreach (string line in lines)
            {   //split the line into parts using ";"
                string[] parts = line.Split(";");
                
                string date = parts[0];
                string promptText = parts[1];
                string entryText = parts[2]; 

                Entry newEntry = new Entry(entryText, promptText);
                _entries.Add(newEntry);
            }
        }
    }
}
