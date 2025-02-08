using System;
class Assignment
{
    // Fields
    //protected string _studentName;
    //protected string _topic;
    private string _studentName;
    private string _topic;
    // Constructor to initialise the fields
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    // methods: getters to access the private variables 
    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }
    
    // Shared method to get a summary of the assignent
    public string GetSummary()
    {
        //return _studentName + " - " + _topic;
        return $"{_studentName} - {_topic}";
    }

}

