using System;

public class EternalGoal : Goal
{
    // Constructor
    public EternalGoal(string shortName, string description, string points)
        : base(shortName, description, points) { }

    // Grants points but never completes
    public override void RecordEvent()
    {
        Console.WriteLine($"Recorded progress on: {GetName()} and earned {GetPoints()} points!");
    }

    // Eternal goals never complete
    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"[ ] {GetName()} ({GetDescription()}) - {GetPoints()} points per event.";
    }

    public override string GetStringRepresentation()
    {
        return $"{GetType().Name}:{GetName()},{GetDescription()},{GetPoints()}";
    }
}


