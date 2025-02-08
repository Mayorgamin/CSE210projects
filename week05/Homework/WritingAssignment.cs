using System;
class WritingAssignment : Assignment
{
    // Field
    private string _title;
    // Constructor to initialise field
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
        {
        _title = title;
        }

    // Method to get title
    public string GetWritingInformation()
    {
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";
    }




}


