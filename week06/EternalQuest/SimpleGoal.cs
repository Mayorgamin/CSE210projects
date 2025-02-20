using System;

public class SimpleGoal : Goal
{
    private bool _isComplete; 

    // Constructor
    public SimpleGoal(string shortName, string description, string points)
        : base(shortName, description, points)  
    {
        _isComplete = false;  // Simple goals start as incomplete
    }
    public override void RecordEvent()
    {
        if (! _isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"Well done! You've completed: {GetName()} and earned {GetPoints()} points.");
        }
        else
        {
            Console.WriteLine($"This goal ({GetName()} is completed.)");
        }        
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetDetailsString()
    {
        return $"[{(_isComplete ? "X" : " ")}] {GetName()} ({GetDescription()}) - {GetPoints()} points.";
    }
    public override string GetStringRepresentation()
    {
        return $"{GetType().Name}:{GetName()},{GetDescription()},{GetPoints()},{_isComplete}";
    }
}




