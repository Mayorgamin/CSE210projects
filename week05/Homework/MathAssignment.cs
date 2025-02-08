using System;
class MathAssignment : Assignment
{
    // Fields
    private string _textbookSection;
    private string _problems;
    // Constructor to initialise the fields
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
        {
            // Set specific variables for MathAssignment
            _textbookSection = textbookSection;
            _problems = problems;
        }
    // Method to get a homework list
    public string GetHomeworkList()
    {
        return $"Section: {_textbookSection} Problems: {_problems}";
    }
 
}

