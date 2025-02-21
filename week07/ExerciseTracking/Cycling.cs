using System;

public class Cycling : Activity
{
    private float _speed;    // Stores speed
    // Constructor
    public Cycling(string date, int minutes, float speed)
    : base(date, minutes)
    {
        _speed = speed;
    }
    // Calculates and returns distance
    public override float GetDistance()
    {
        return (_speed * _minutes) / 60;
    }
    // Returns speed (already stored)
    public override float GetSpeed()
    {
        return _speed;
    }
    // Calculates and returns pace
    public override float GetPace()
    {
        return 60 / _speed;
    }
}





