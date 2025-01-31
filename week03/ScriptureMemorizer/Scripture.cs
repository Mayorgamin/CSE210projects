using System;
using System.Collections.Generic; //required for lists
using System.Text.RegularExpressions; //required for Regex 
class Scripture
{
    // Private fields
    private Reference _reference;
    private List<Word> _words;

    // Constructor to initialise the fields
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>(); //initialise list

        string pattern = @"\w+|[.,;:]";
        MatchCollection matches = Regex.Matches(text, pattern);

        foreach (Match match in matches)
        {
            _words.Add(new Word(match.Value));
        }
    }
    // Method to hide random words
    public void HideRandomWords(int numberToHide)
    {
        // Count already hidden words
        int alreadyHiddenCount = 0;
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                alreadyHiddenCount++;
            }
        }
        // If all words are already hidden, exit early the HideRandomWords method
        if (alreadyHiddenCount == _words.Count)
        {
            return;
        }
        // Count visible words
        int visibleWordsCount = _words.Count - alreadyHiddenCount;
        // Ensure numberToHide doesn't exceed visible words
            if (numberToHide > visibleWordsCount)
        {
            numberToHide = visibleWordsCount;
        }
        
        // Hide words randomly
        int hiddenWordsCount = 0;
        Random random = new Random(); // Create the random object
        while (hiddenWordsCount < numberToHide)
        {
            int index = random.Next(0, _words.Count); // Generate random number
            // Only hide words that are not already hidden
            if (!_words[index].IsHidden())
            {
                _words[index].Hide(); 
                hiddenWordsCount++; // ncrements only if a word is hidden
            }
        }
    }
    public string GetDisplayText()
    {
        List<string> wordsList = new List<string>(); // Declare list
        foreach (Word word in _words) // Loop through each word
        {
            wordsList.Add(word.GetDisplayText()); // Add word's text to the list
        }
        //Return reference as string and ensure spaces 
        return _reference.ToString() + " " + string.Join("", wordsList.Select((word, index) =>
        (index > 0 && (char.IsLetter(word[0]) || word[0] == '_') ? " " : "") + word));
    }
    //method to check if all words are hidden
    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden()) // If a word is still visible
            {
                return false; // not all words are hidden: exit method
            }
        }
        return true;    
    }
}


