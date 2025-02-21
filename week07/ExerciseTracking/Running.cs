using System;

public class Running : Activity
{
    private float _distance;    // Stores distance in km
    // Constructor
    public Running(string date, int minutes, float distance)
    : base(date, minutes)
    {
        _distance = distance;
    }
    // Returns distance (already stored)
    public override float GetDistance()
    {
        return _distance;
    }
    // Calculates and returns speed
    public override float GetSpeed()
    {
        return (_distance / _minutes) * 60;
    }
    // Calculates and returns pace
    public override float GetPace()
    {
        return _minutes / _distance;
    }
}



