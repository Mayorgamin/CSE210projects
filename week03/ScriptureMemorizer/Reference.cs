using System;
class Reference
{   // Fields set to private 
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // constructors
    // Constructor used for single verse
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = -1;
    }
    // Constructor used for more than one verse
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    // Getters(public to allow acces to the fields)
    public string GetBook() { return _book; }
    public int GetChapter() { return _chapter; }
    public int GetVerse() { return _verse; }
    public int GetEndVerse() { return _endVerse; }
 
    // ToString method
    public override string ToString()
    {
        if(_endVerse == -1) //one verse
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else //more than one verse
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}

