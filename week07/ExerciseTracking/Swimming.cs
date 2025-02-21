using System;

public class Swimming : Activity
{
    private int _laps;    // Stores laps
    // Constructor
    public Swimming(string date, int minutes, int laps)
    : base(date, minutes)
    {
        _laps = laps;
    }
    // Calculates and returns distance
    public override float GetDistance()
    {
        return (_laps * 50f) / 1000f; // converted to km (laps * 50)
    }
    // Calculates and returns speed
    public override float GetSpeed()
    {
        return (GetDistance() / _minutes) * 60;
    }
    // Calculates and returns pace
    public override float GetPace()
    {
        return _minutes / GetDistance();
    }
}

