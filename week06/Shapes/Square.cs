using System;

public class Square : Shape
{
    private double _side;
    
    // Constructor
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }
    // Overrride GetArea()
    public override double GetArea()
    {
        return _side * _side; // Area of a square = side * side
    }
}



