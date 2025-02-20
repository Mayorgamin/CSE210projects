using System;

public abstract class Shape
{
    private string _color;
    
    // Constructor
    public Shape(string color)
    {
        _color = color;
    }

    // getter for color
    public string GetColor()
    {
        return _color;
    }
    
    // Abstract method for area calculation
    public abstract double GetArea();
}

