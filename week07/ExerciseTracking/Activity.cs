using System;

public abstract class Activity
{
    protected string _date;
    protected int _minutes;
    // Constructor
    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }
    public abstract float GetDistance();
    public abstract float GetSpeed();
    public abstract float GetPace();
    public virtual string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_minutes} min) - Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
    }


}