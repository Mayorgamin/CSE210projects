using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    // Constructor
    public ChecklistGoal(string shortName, string description, string points, int target, int bonus)
        : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        Console.WriteLine($"Progress recorded for: {GetName()} ({_amountCompleted}/{_target} completed).");

        if (_amountCompleted == _target)
        {
            Console.WriteLine($"Goal achieved! You earned {GetPoints()} points plus a bonus of {_bonus} points!");
        }
        else
        {
            Console.WriteLine($"Keep going! You earned {GetPoints()} points. {_target - _amountCompleted} more to go.");
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {GetName()} ({GetDescription()}) - {GetPoints()} points per event. " +
               $"Completed {_amountCompleted}/{_target} times.";
    }

    public override string GetStringRepresentation()
    {
        return $"{GetType().Name}:{GetName()},{GetDescription()},{GetPoints()},{_target},{_bonus},{_amountCompleted}";
    }
}


