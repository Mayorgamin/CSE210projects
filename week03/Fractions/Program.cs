using System;

class Program
{
    static void Main(string[] args)
    {
        // Test constructor without parameters
        Fraction frac1 = new Fraction();
        Console.WriteLine(frac1.GetFractionString()); // Expected: "1/1"
        Console.WriteLine(frac1.GetDecimalValue());  // Expected: 1.0

        // Test one-parameter constructor
        Fraction frac2 = new Fraction(5);
        Console.WriteLine(frac2.GetFractionString()); // Expected: "5/1"
        Console.WriteLine(frac2.GetDecimalValue());  // Expected: 5.0

        // Test two-parameter constructor
        Fraction frac3 = new Fraction(3, 4);
        Console.WriteLine(frac3.GetFractionString()); // Expected: "3/4"
        Console.WriteLine(frac3.GetDecimalValue());  // Expected: 0.75

        // Test Setters(top and bottom)
        frac3.SetTop(1);
        frac3.SetBottom(3);
        Console.WriteLine(frac3.GetFractionString()); // Expected: "1/3"
        Console.WriteLine(frac3.GetDecimalValue());  // Expected: 0.3333333333333333
        
    }
}