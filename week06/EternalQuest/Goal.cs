using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;
    // Constructor
    public Goal(string shortName, string description, string points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }
    // Getters for fields
    public string GetName() => _shortName;
    public string GetDescription() => _description;
    public string GetPoints() => _points;

    // Abstract method for recording event
    public abstract void RecordEvent();

    // Virtual method for when completing the goal
    public virtual bool IsComplete()
    {
        return false; // Most goals are incomplete, need override
    }
    // Virutal method used by Checklist Goal to track progress
    public virtual string GetDetailsString()
    {
        return $"{_shortName} ({_description}) -- {_points} points";
    }
    // Virtual method to help save goals in a file
    public virtual string GetStringRepresentation()
    {
        return $"{GetType().Name}: {_shortName}, {_description}, {_points}";
    }
}



