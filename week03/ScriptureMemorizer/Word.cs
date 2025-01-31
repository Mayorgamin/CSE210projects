using System;
class Word
{
    // Fields (private)
    private string _text;
    private bool _isHidden;

    // Constructor to initialise _text and _isHidden
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Implement methods
    public void Hide() //method to hide words
    {
        _isHidden = true;
    }
    public void Show() //method to show words
    {
        _isHidden = false;
    }
    public bool IsHidden() //method to check if a word is hidden
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        if (_isHidden && _text.Any(char.IsLetter)) // Hide only words even if there's punctuation
        {
            string hiddenPart = new string('_', _text.Count(char.IsLetter)); // Hide only letters
            string punctuation = new string(_text.Where(c => !char.IsLetter(c)).ToArray()); // Keep punctuation
            return hiddenPart + punctuation; 
        }
        else
        {
            return _text;
        }
    }
}


