using System;

namespace journal
{

    public class Entry
    {
        //Property for storing the journal entries
        public string _entryText {get; set;}

        // Property for storing the date of the entries
        public string _date {get; set;}

        public string _promptText {get; set;}

        // Constructor to intitialize the entry with text and date
        public Entry(string entryText, string promptText,  string date = null)
        {   // Assign the passed parameters to the property
            _entryText = entryText; //store entry
            _promptText = promptText; //store prompt
            // If not date is provided (null), the current date is used 
            _date = date ?? DateTime.Now.ToString("yyyy-MM-dd");
        }

        public override string ToString()
        {
            return $"{_date}; {_promptText}; {_entryText}";
        }
    }
}